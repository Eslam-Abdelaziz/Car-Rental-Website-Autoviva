using AdminPanel.Services;
using System;
using System.Windows.Forms;

namespace AdminPanel.Forms.Branch
{
    public partial class Frm_Add : Form
    {
        private Frm_List Frm_List;
        private BranchService _branchService;
        public Frm_Add(Frm_List frm_List, BranchService branchService)
        {
            InitializeComponent();
            Frm_List = frm_List;
            _branchService = branchService;
        }

        private async void AddBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(BranchText.Texts))
            {
                MessageBox.Show("Please Add Name");
                return;
            }

            if (string.IsNullOrEmpty(StreetText.Texts))
            {
                MessageBox.Show("Please Add Street");
                return;
            }
            if (string.IsNullOrEmpty(CityText.Texts))
            {
                MessageBox.Show("Please Add City");
                return;
            }
            if (string.IsNullOrEmpty(ZipCodeText.Texts))
            {
                MessageBox.Show("Please Add Zip Code");
                return;
            }
            if (string.IsNullOrEmpty(StateText.Texts))
            {
                MessageBox.Show("Please Add State");
                return;
            }

            if (!int.TryParse(ZipCodeText.Texts, out int zipcode))
            {
                MessageBox.Show("Please Enter Valid Zip Code");

                return;
            }
            var b = new Models.Branch()
            {
                Name = BranchText.Texts,
                Address = new Models.Address()
                {
                    Street = StreetText.Texts,
                    City = CityText.Texts,
                    State = StateText.Texts,
                    Phone = PhoneText.Texts,
                    ZipCode = zipcode
                }
            };
            if (await _branchService.AddBranch(b)) 
            {
                Frm_List.UpdateList();
                this.Close();
            }
        }
    }
}
