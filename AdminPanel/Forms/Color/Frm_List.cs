using AdminPanel.Extenstions;
using AdminPanel.Models;
using AdminPanel.Services;
using System;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminPanel.Forms.Color
{
    public partial class Frm_List : Form
    {
        private readonly ColorService _colorService;
        public Frm_List(ColorService colorService)
        {
            InitializeComponent();

            ImageList imgList = new ImageList();
            imgList.ImageSize = new Size(1, 50);
            ListColors.SmallImageList = imgList;
            _colorService = colorService;
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
            var colors = await _colorService.GetColorsAsync();
            lblBrands.Text = $"Colors : {colors?.Count}";
            ListColors.Items.Clear();
            var Items = colors?.DistinctBy(x => x.Name.ToLower()).OrderBy(x=>x.Name).Select(color =>
            {
                var item = new ListViewItem(color.Name);
                item.Tag = color;
                return item;
            });
            ListColors.Items.AddRange(Items.ToArray());
        }


        private void Frm_List_Load(object sender, System.EventArgs e)
        {
        }

        private void LogBtn_Click(object sender, System.EventArgs e)
        {
            Frm_Add frm = new Frm_Add(this, _colorService);
            frm.ShowDialog();
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (ListColors.SelectedIndices.Count != 1) 
            {
                MessageBox.Show("Please Select A Brand");
                return;
            }

            new Frm_Edit(this, _colorService, (Models.Color)ListColors.SelectedItems[0].Tag)
                .ShowDialog() ;

        }

     


    }
}
