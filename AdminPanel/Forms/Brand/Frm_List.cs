using AdminPanel.Services;
using System;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminPanel.Forms.Brand
{
	public partial class Frm_List : Form
    {
        private BrandService _brandService;
        private ModelService _modelService;

        public Frm_List(BrandService brandService, ModelService modelService)
        {
            InitializeComponent();
            _brandService = brandService;

            ImageList imgList = new ImageList();
            imgList.ImageSize = new Size(1, 50);
            ListBrands.SmallImageList = imgList;
            _modelService = modelService;
        }
        protected async override void OnVisibleChanged(EventArgs e)
		{
			if (Visible)
			{
                await UpdateBrands();
			}
			base.OnVisibleChanged(e);
		}
		internal async Task UpdateBrands()
        {
            var Brands = await _brandService.GetBrandsAsync();
            lblBrands.Text = $"Brands : {Brands.Count}";
            ListBrands.Items.Clear();
            var Items = Brands.OrderBy(x => x.Name).Select(brand =>
            {
                var item = new ListViewItem(brand.Name);
                item.SubItems.Add(brand.Models.Count.ToString());
                item.Tag = brand;
                return item;
            });
            ListBrands.Items.AddRange(Items.ToArray());
        }



        private void LogBtn_Click(object sender, System.EventArgs e)
        {
            Frm_Add frm = new Frm_Add(this,_brandService);
            frm.ShowDialog();
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (ListBrands.SelectedIndices.Count != 1) 
            {
                MessageBox.Show("Please Select A Brand");
                return;
            }

            new Frm_Edit(this, _brandService, (Models.Brand)ListBrands.SelectedItems[0].Tag)
                .ShowDialog() ;

        }

		private void Frm_List_Load(object sender, EventArgs e)
		{

		}

        private void ModelsBtn_Click(object sender, EventArgs e)
        {
            if (ListBrands.SelectedIndices.Count != 1)
            {
                MessageBox.Show("Please Select A Brand");
                return;
            }
            new Model.Frm_List((Models.Brand)ListBrands.SelectedItems[0].Tag, _modelService)
               .ShowDialog();
        }
    }
}
