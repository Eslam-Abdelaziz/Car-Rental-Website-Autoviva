using AdminPanel.Services;
using System;
using System.Windows.Forms;

namespace AdminPanel.Forms.Brand
{
    public partial class Frm_Edit : Form
    {
        private Frm_List Frm_List;
        private BrandService _brandService;
        private Models.Brand _brand;
        public Frm_Edit(Frm_List frm_List, BrandService brandService, Models.Brand brand)
        {
            InitializeComponent();
            Frm_List = frm_List;
            _brandService = brandService;
            _brand = brand;
        }

        private async void EditBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(BrandText.Texts)) 
            {
                MessageBox.Show("Please Add Name");
                return;
            }
            if (await _brandService.EditBrand(_brand.Id,BrandText.Texts)) 
            {
                Frm_List.UpdateBrands();
                this.Close();
            }
        }

        private void Frm_Edit_Load(object sender, EventArgs e)
        {
            BrandText.Texts = _brand.Name;
        }
    }
}
