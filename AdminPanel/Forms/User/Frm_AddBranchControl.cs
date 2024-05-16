using AdminPanel.Models;
using AdminPanel.Services;
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
	public partial class Frm_AddBranchControl : Form
	{
		private BranchService _branchService;
		private UserService _userService;
		private Models.User _user;
		public Frm_AddBranchControl(BranchService branchService, Models.User user, UserService userService)
		{
			InitializeComponent();
			_branchService = branchService;
			_user = user;
			_userService = userService;
		}

		private async void AddBtn_Click(object sender, EventArgs e)
		{
			if (BranchCombo.SelectedIndex == -1) 
			{
				MessageBox.Show("Please Select a Branch");
				return;
			}
			var branch = (Models.Branch)BranchCombo.SelectedItem;
			if (branch == null) 
			{
				MessageBox.Show("Some Thing Bad Happend");
				return;
			}

			if (await _userService.AddBranchUser(_user, branch)) 
			{
				MessageBox.Show("Opreation Success.");
				this.Hide();
			}
			else 
			{
				MessageBox.Show("Some Thing Bad Happend");
				return;
			}
		}

		private async void Frm_AddBranchControl_Load(object sender, EventArgs e)
		{
			UserText.Text = _user.ToString();
			var branches = await _branchService.GetBranchesAsync();
			if (branches != null) 
			{
				BranchCombo.Items.AddRange(branches.ToArray());
			}
		}
	}
}
