using AdminPanel.Services;
using System;
using System.Windows.Forms;

namespace AdminPanel.Forms.Auth
{
    public partial class Frm_Login : Form
    {
        private AuthService _authService;
        private Frm_Main _frmMain;
        public Frm_Login(AuthService authService, Frm_Main frm_Main, Frm_Main frmMain)
        {
            InitializeComponent();
            _authService = authService;
            _frmMain = frmMain;
        }

        private async void LoginBtn_Click(object sender, EventArgs e)
        {

            //if (string.IsNullOrEmpty(EmailText.Text))
            //{
            //    MessageBox.Show("Please Enter Email Address.");
            //    return;
            //}

            //if (string.IsNullOrEmpty(PassText.Text))
            //{
            //    MessageBox.Show("Please Enter Password.");
            //    return;
            //}
           var res = await _authService.LoginAsync("admin@localhost.com", "P@ssword1");

            if (res != null)
            {
                _authService.SetAuthKey(res.Token);
                this.Hide();
                _frmMain.ShowForm(res.User,res.IsAdmin);

            }
            else
            {
                MessageBox.Show("Signing in failed.", "");
            }
        }

        private void Frm_Login_Load(object sender, EventArgs e)
        {
            this.EmailText.Texts = "admin@localhost.com";
            this.PassText.Texts = "P@ssword1";
        }
    }
}
