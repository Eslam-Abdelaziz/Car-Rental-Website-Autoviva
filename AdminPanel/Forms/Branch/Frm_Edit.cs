using AdminPanel.Services;
using System;
using System.Windows.Forms;

namespace AdminPanel.Forms.Branch
{
    public partial class Frm_Edit : Form
    {
        private Frm_List Frm_List;
        private BranchService _branchService;
        private Models.Branch _branch;
        public Frm_Edit(Frm_List frm_List, BranchService brandService, Models.Branch branch)
        {
            InitializeComponent();
            Frm_List = frm_List;
            _branchService = brandService;
            _branch = branch;
        }

   
        private void Frm_Edit_Load(object sender, EventArgs e)
        {
            BranchText.Texts = _branch.Name;
            PhoneText.Texts = _branch.Address.Phone;
            ZipCodeText.Texts = _branch.Address.ZipCode.ToString();
            StreetText.Texts = _branch.Address.Street;
            CityText.Texts = _branch.Address.City;
            StateText.Texts = _branch.Address.State;
        }

        private async void EditBtn_Click(object sender, EventArgs e)
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

            if (!int.TryParse(ZipCodeText.Texts,out int zipcode)) 
            {
                MessageBox.Show("Please Enter Valid Zip Code");

                return;
            }
            var b = new Models.Branch()
            {
                Id = _branch.Id,
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
            if (await _branchService.EditBranch(b)) 
            {
                this.Close();
                Frm_List.UpdateList();
            }
        }
    }
}
