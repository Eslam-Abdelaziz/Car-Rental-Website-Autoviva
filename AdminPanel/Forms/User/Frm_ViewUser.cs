using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminPanel.Forms.User
{
    public partial class Frm_ViewUser : Form
    {

        public Frm_ViewUser(Models.User user)
        {
            InitializeComponent();
            NameText.Texts = user.ToString();
            EmailText.Texts = user.Email;
            Text = user.ToString() ;
        }

        private void Frm_ViewUser_Load(object sender, EventArgs e)
        {

        }

        private void rjTextBox1__TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
