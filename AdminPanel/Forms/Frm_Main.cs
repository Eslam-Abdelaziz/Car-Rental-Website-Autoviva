using AdminPanel.Services;
using System;
using System.Windows.Forms;

namespace AdminPanel.Forms
{
	public partial class Frm_Main : Form
    {
        private User.Frm_List _frmUsers;
        private Brand.Frm_List _frmBrands;
        private Branch.Frm_List _frmBranches;
        private Color.Frm_List _frmColors;
        private Car.Frm_List _frmCars;
        private Models.User _user;
        private Rental.Frm_List _frmRentals;
        private Frm_Statistics _frmStatistics;

        private RentalService rentalService;
        public Frm_Main(User.Frm_List frmUsers, Brand.Frm_List frmBrands, Branch.Frm_List frmBranches, Color.Frm_List frmColors, Car.Frm_List frmCars, Rental.Frm_List frmRentals, RentalService rentalService, Frm_Statistics frmStatistics)
        {
            InitializeComponent();
            hideSubMenu();
            _frmUsers = frmUsers;
            _frmBrands = frmBrands;
            _frmBranches = frmBranches;
            _frmColors = frmColors;
            _frmCars = frmCars;
            _frmRentals = frmRentals;
            this.rentalService = rentalService;

            _frmStatistics = frmStatistics;
        }

        private void hideSubMenu()
        {
            panelMediaSubMenu.Visible = false;
            panelPlaylistSubMenu.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void btnMedia_Click(object sender, EventArgs e)
        {
            showSubMenu(panelMediaSubMenu);
        }

        #region MediaSubMenu
        private void button2_Click(object sender, EventArgs e)
        {
         
        }


        private void button4_Click(object sender, EventArgs e)
        {

    
        }

   
        #endregion

        private void btnPlaylist_Click(object sender, EventArgs e)
        {
            showSubMenu(panelPlaylistSubMenu);
        }

        #region PlayListManagemetSubMenu
        private void button8_Click(object sender, EventArgs e)
        {
            openChildForm(_frmCars);
            //..
            //your codes
            //..
            hideSubMenu();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //..
            //your codes
            //..
            hideSubMenu();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //..
            //your codes
            //..
            hideSubMenu();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //..
            //your codes
            //..
            hideSubMenu();
        }
        #endregion


        #region ToolsSubMenu
        private void button13_Click(object sender, EventArgs e)
        {
            //..
            //your codes
            //..
            hideSubMenu();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            //..
            //your codes
            //..
            hideSubMenu();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //..
            //your codes
            //..
            hideSubMenu();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //..
            //your codes
            //..
            hideSubMenu();
        }
        #endregion

        private void btnEqualizer_Click(object sender, EventArgs e)
        {
           // openChildForm(new Form3());
            //..
            //your codes
            //..
            hideSubMenu();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            //..
            //your codes
            //..
            hideSubMenu();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null) 
            {
                activeForm.Visible = false;
            }
            activeForm = childForm;
            childForm.TopLevel = false;
           
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        public void ShowForm(Models.User user,bool IsAdmin = false) 
        {
            if (!IsAdmin) 
            {
				UsersBtn.Hide();
                panelMediaSubMenu.Height -=UsersBtn.Height;
                BranchesBtn.Hide();
				panelMediaSubMenu.Height -= BranchesBtn.Height;

			}
			_user = user;

			Text = string.Format("User => {0}", user);

            lblUser.Text = user.ToString();
     Show();
        }

		private void ColorsBtn_Click(object sender, EventArgs e)
		{
			openChildForm(_frmColors);
			//..
			//your codes
			//..
			hideSubMenu();
		}

		private void BrandsBtn_Click(object sender, EventArgs e)
		{

			openChildForm(_frmBrands);//..
									  //your codes
									  //..
			hideSubMenu();
		}

		private void BranchesBtn_Click(object sender, EventArgs e)
		{
			openChildForm(_frmBranches);
			//..
			//your codes
			//..
			hideSubMenu();
		}

		private void UsersBtn_Click(object sender, EventArgs e)
		{
			openChildForm(_frmUsers);
			// openChildForm(new Form2());
			//..
			//your codes
			//..
			hideSubMenu();
		}
        private void RentalsBtn_Click(object sender, EventArgs e)
        {
            openChildForm(_frmRentals);
            hideSubMenu();

        }

        private void LogoPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Frm_Main_Load(object sender, EventArgs e)
        {

        }

        private void panelSideMenu_Paint(object sender, PaintEventArgs e)
        {

        }

   

        private void iconButton2_Click(object sender, EventArgs e)
        {
            openChildForm(_frmStatistics);
            hideSubMenu();
        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
