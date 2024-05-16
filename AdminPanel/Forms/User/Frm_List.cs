using AdminPanel.Services;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminPanel.Forms.User
{
    public partial class Frm_List : Form
    {
        private readonly UserService _userService;
        private readonly BranchService _branchService;
		public Frm_List(UserService userService, BranchService branchService)
		{
			InitializeComponent();
			_userService = userService;
			_branchService = branchService;
		}
		protected async override void OnVisibleChanged(EventArgs e)
		{
			if (Visible)
			{
                await GetAndAddUsers();
            }
            base.OnVisibleChanged(e);
		}
		private async void EmailSrcText__TextChanged(object sender, System.EventArgs e)
        {
            await GetAndAddUsers();
        }

        private async void CityText__TextChanged(object sender, System.EventArgs e)
        {
            await GetAndAddUsers();
        }

        private async void PhoneText__TextChanged(object sender, System.EventArgs e)
        {
            await GetAndAddUsers();
        }

        private async void LastText__TextChanged(object sender, System.EventArgs e)
        {
            await GetAndAddUsers();
        }
        private bool IsBranchToggled = false;
        private async Task GetAndAddUsers(bool filter = false)
        {
            var Users = await _userService.GetUsersAsync(EmailSrcText.Texts, FirstText.Texts, LastText.Texts, CityText.Texts, PhoneText.Texts);
            if (filter) 
            {
                if (IsBranchToggled)
                {
                    Users = Users.Where(x => x.BranchId != null).ToList();
                    IsBranchToggled = false;
                }
                else
                {
                    Users = Users.Where(x => x.BranchId == null).ToList();
                }
            }
            
            ListUsers.Items.Clear();
            var Items = Users?.Select(user => 
            {
                var item = new ListViewItem(user.Email);
                item.SubItems.Add(user.Firstname);
                item.SubItems.Add(user.Lastname);
                item.SubItems.Add(user.GetAddress);
                item.SubItems.Add(user.GetPhone);
                item.Tag = user
                ;
                return item;
            });
            ListUsers.Items.AddRange(Items.ToArray());
           
        }


		private void addBranchControlToolStripMenuItem_Click(object sender, EventArgs e)
		{
            if (ListUsers.SelectedIndices.Count  == 1) 
            {
                new Frm_AddBranchControl(_branchService, (Models.User)ListUsers.SelectedItems[0].Tag,_userService).ShowDialog();
            }
            else 
            {
                MessageBox.Show("Please Select a User");
            }
		}

        private async void IsBranchAdminToggle_CheckedChanged(object sender, EventArgs e)
        {
            IsBranchToggled = IsBranchAdminToggle.Checked;
            await GetAndAddUsers(true);
        }

        private async void deleteBranchControlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ListUsers.SelectedIndices.Count == 1)
            {
                var user = (Models.User)ListUsers.SelectedItems[0].Tag;
                if (await _userService.DeleteBranchUser(user)) 
                {
                    MessageBox.Show("Deleted Branch Control");
                }
                else 
                {
                    MessageBox.Show("Error When Deleing Branch Contorl");
                }
                await GetAndAddUsers();
            }
            else
            {
                MessageBox.Show("Please Select a User");
            }
        }

        private async void FirstText__TextChanged(object sender, EventArgs e)
        {
            await GetAndAddUsers();

        }

        private async void StreetText__TextChanged(object sender, EventArgs e)
        {
            await GetAndAddUsers();

        }
    }
}
