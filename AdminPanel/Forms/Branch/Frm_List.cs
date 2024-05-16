using AdminPanel.Services;
using System;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminPanel.Forms.Branch
{
    public partial class Frm_List : Form
    {
        private BranchService _branchService;

        public Frm_List(BranchService branchService)
        {
            InitializeComponent();

            ImageList imgList = new ImageList();
            imgList.ImageSize = new Size(1, 50);
            ListBranches.SmallImageList = imgList;
            _branchService = branchService;
        }
		protected async override void OnVisibleChanged(EventArgs e)
		{
			if (Visible)
			{
				await UpdateList();
			}
			base.OnVisibleChanged(e);
		}
		internal async Task UpdateList()
        {
            var branches = await _branchService.GetBranchesAsync();
            lblBrands.Text = $"Branches : {branches.Count}";
            ListBranches.Items.Clear();
            var Items = branches.OrderBy(x => x.Name).Select(branch =>
            {
                var item = new ListViewItem(branch.Name);
                item.SubItems.Add(branch.Address.ToString());
                item.SubItems.Add(branch.Address.Phone);

                item.Tag = branch;
                return item;
            });
            ListBranches.Items.AddRange(Items.ToArray());
        }


        private void Frm_List_Load(object sender, System.EventArgs e)
        {
            UpdateList();
        }

        private void LogBtn_Click(object sender, System.EventArgs e)
        {
            Frm_Add frm = new Frm_Add(this,_branchService);
            frm.ShowDialog();
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (ListBranches.SelectedIndices.Count != 1) 
            {
                MessageBox.Show("Please Select A Brand");
                return;
            }

            new Frm_Edit(this, _branchService, (Models.Branch)ListBranches.SelectedItems[0].Tag)
                .ShowDialog() ;

        }

     


    }
}
