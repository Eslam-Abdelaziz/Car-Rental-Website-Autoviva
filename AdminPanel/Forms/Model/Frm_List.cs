using AdminPanel.Extenstions;
using AdminPanel.Models;
using AdminPanel.Services;
using System;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminPanel.Forms.Model
{
    public partial class Frm_List : Form
    {
        private Models.Brand _brand;
        private ModelService _modelService;
        public Frm_List(Models.Brand brand, ModelService modelService)
        {
            InitializeComponent();
            _brand = brand;
            ImageList imgList = new ImageList();
            imgList.ImageSize = new Size(1, 50);
            LstModels.SmallImageList = imgList;
            _modelService = modelService;
            Text = $"Models for {_brand.Name}";
        }
        protected async override void OnVisibleChanged(EventArgs e)
		{
			if (Visible)
			{
				await UpdateColors();
			}
			base.OnVisibleChanged(e);
		}
		internal async Task UpdateColors() 
        {
            var models = await _modelService.Get(_brand.Id);
            lblBrands.Text = $"Models : {models?.Count}";
            LstModels.Items.Clear();
            var Items = models?.OrderBy(x=>x.Name).Select(model =>
            {
                var item = new ListViewItem(model.Name);
                item.Tag = model;
                return item;
            });
            LstModels.Items.AddRange(Items.ToArray());
        }


        private void Frm_List_Load(object sender, System.EventArgs e)
        {
        }

        private void LogBtn_Click(object sender, System.EventArgs e)
        {
            Frm_Add frm = new Frm_Add(this, _modelService,_brand);
            frm.ShowDialog();
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (LstModels.SelectedIndices.Count != 1) 
            {
                MessageBox.Show("Please Select A Brand");
                return;
            }

            new Frm_Edit(this, _modelService, _brand,(Models.Model)LstModels.SelectedItems[0].Tag)
                .ShowDialog() ;

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
