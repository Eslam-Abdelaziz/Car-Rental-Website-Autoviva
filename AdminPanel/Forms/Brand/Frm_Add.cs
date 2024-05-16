using AdminPanel.Services;
using System;
using System.Windows.Forms;

namespace AdminPanel.Forms.Brand
{
    public partial class Frm_Add : Form
    {
        private Frm_List Frm_List;
        private BrandService _brandService;
        public Frm_Add(Frm_List frm_List, BrandService brandService)
        {
            InitializeComponent();
            Frm_List = frm_List;
            _brandService = brandService;
        }

        private async void AddBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(BrandText.Texts)) 
            {
                MessageBox.Show("Please Add Name");
                return;
            }
            if (await _brandService.AddBrand(BrandText.Texts)) 
            {
                await Frm_List.UpdateBrands();
                this.Close();
            }
        }
    }
}
