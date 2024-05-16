using AdminPanel.Extenstions;
using AdminPanel.Models;
using AdminPanel.Services;
using RJCodeAdvance.RJControls;
using System;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminPanel.Forms.Car
{
    public partial class Frm_List : Form
    {
        private BranchService _branchService;
        private ColorService _colorService;
        private BrandService _BrandService ;
		private CarService _carService;
		private bool IsElectricToggleChange = false;
        private bool IsAutomaticToggleChange = false;

        public Frm_List(BranchService branchService, ColorService colorService, BrandService brandService, CarService carService)
		{
			InitializeComponent();

			ImageList imgList = new ImageList();
			imgList.ImageSize = new Size(1, 50);
			ListCars.SmallImageList = imgList;
			_branchService = branchService;
			_colorService = colorService;
			_BrandService = brandService;
			_carService = carService;
		}

		protected async override void OnVisibleChanged(EventArgs e)
		{
            if (Visible) 
            {
				await UpdateData();
				await UpdateCars();
			}
			base.OnVisibleChanged(e);
		}

		internal async Task UpdateData()
        {
			BranchCombo.Items.Clear();
			BrandCombo.Items.Clear();
			ColorCombo.Items.Clear();
			SizeCombo.Items.Clear();
			var branches = await _branchService.GetBranchesAsync();
			
			BranchCombo.Items.AddRange(branches.ToArray());

			var brands = await _BrandService.GetBrandsAsync();
			BrandCombo.Items.AddRange(brands.ToArray());

			var colors = await _colorService.GetColorsAsync();
			ColorCombo.Items.AddRange(colors.ToArray());

			for (int i = 0; i < 5; i++)
			{
				SizeCombo.Items.Add(((CarSize)i).ToFriendlyName());
			}

            lblBrands.Text = $"Cars : {await _carService.GetCarsCount()}";
		}

		internal async Task UpdateCars() 
		{
			var branch = (Models.Branch)BranchCombo.SelectedItem;
			var brand = (Models.Brand)BrandCombo.SelectedItem;
			var color = (Models.Color)ColorCombo.SelectedItem;

			int? size = SizeCombo.SelectedIndex;
			if (SizeCombo.SelectedIndex == -1)
			{
				size = null;
			}
			bool? ElectricToggle = null;
			bool? AutomaticeToggle = null;
			if (IsElectricToggleChange) 
			{
				ElectricToggle = IsElectricToggle.Checked;
				IsElectricToggleChange = false;
			}
			if(IsAutomaticToggleChange) 
			{
				AutomaticeToggle = IsAutomatic.Checked;
				IsAutomaticToggleChange = false;
            }
			var Cars = await _carService.GetCarsAsync(NameText.Texts, ModelYearText.Texts, brand?.Id, branch?.Id, color?.Id, size, SeatsText.Texts,
				PriceText.Texts, ElectricToggle, AutomaticeToggle);
			if (Cars == null)
			{
				return;
			}
			ListCars.Items.Clear();
			var Items = Cars.Select(car =>
			{
				var item = new ListViewItem(car.Name);
				item.SubItems.Add(car.Brand.Name);
				item.SubItems.Add(car.ModelYear.ToString());
				item.SubItems.Add(car.Branch.Name);
				item.SubItems.Add(car.Color.Name);
				item.SubItems.Add(car.Size.ToString());
				item.SubItems.Add(car.Seats.ToString());
				item.SubItems.Add(car.IsElectric.ToString());
                item.SubItems.Add(car.IsAutomatic.ToString());

                item.SubItems.Add(car.DailyPrice.ToString());
				item.Tag = car;
				return item;
			});
			ListCars.Items.AddRange(Items.ToArray());
		}
    

        private void LogBtn_Click(object sender, System.EventArgs e)
        {
            Frm_Add frm = new Frm_Add(this,_branchService,
                _colorService,_BrandService,_carService);
            frm.ShowDialog();
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {

            if (ListCars.SelectedIndices.Count != 1)
            {
                MessageBox.Show("Please Select A Car");
                return;
            }
            new Frm_Edit(this, _branchService,_colorService,_BrandService,_carService, (Models.Car)ListCars.SelectedItems[0].Tag)
                .ShowDialog();

        }

		private async void BranchCombo_OnSelectedIndexChanged(object sender, EventArgs e)
		{

			await UpdateCars();
		}



		private void SeatsText_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
			{
				e.Handled = true;
			}
		}

		private void ModelYearText_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
			{
				e.Handled = true;
			}
		}

		private void PriceText_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != '-')
			{
				e.Handled = true;
			}

			// Allow negative sign only as the first character
			if (e.KeyChar == '-' && ((sender as RJTextBox).Texts.IndexOf('-') > -1 || (sender as TextBox).SelectionStart > 0))
			{
				e.Handled = true;
			}

			// Allow decimal point only if it's not already present in the textbox
			if (e.KeyChar == '.' && (sender as RJTextBox).Texts.IndexOf('.') > -1)
			{
				e.Handled = true;
			}
		}

		private async void ColorCombo_OnSelectedIndexChanged(object sender, EventArgs e)
		{
			await UpdateCars();
		}

		private async void BrandCombo_OnSelectedIndexChanged(object sender, EventArgs e)
		{
			await UpdateCars();
		}

		private async void ModelYearText__TextChangedAsync(object sender, EventArgs e)
		{
			await UpdateCars();
		}

		private async void SeatsText__TextChanged(object sender, EventArgs e)
		{
			await UpdateCars();
		}

		private async void PriceText__TextChanged(object sender, EventArgs e)
		{
			await UpdateCars();
		}

		private async void NameText__TextChanged(object sender, EventArgs e)
		{
			await UpdateCars();
		}

		private async void IsElectricToggle_CheckedChanged(object sender, EventArgs e)
		{
			IsElectricToggleChange = true;
			await UpdateCars();
		}

	

		private async void SizeCombo_OnSelectedIndexChanged(object sender, EventArgs e)
		{
			IsElectricToggleChange = true;
			await UpdateCars();
		}


		private void ListCars_DoubleClick(object sender, EventArgs e)
		{
			if (ListCars.SelectedIndices.Count == 1 ) 
			{
				new Frm_View(_carService, (Models.Car)ListCars.SelectedItems[0].Tag).ShowDialog();
			}
		}

        private async void ClearBtn_Click(object sender, EventArgs e)
        {

            BranchCombo.SelectedIndex = -1;
            BranchCombo.Texts = "Select Branch";


            BrandCombo.SelectedIndex = -1;
            BrandCombo.Texts = "Select Brand";


            ColorCombo.SelectedIndex = -1;
            ColorCombo.Texts = "Select Color";


            SizeCombo.SelectedIndex = -1;
            SizeCombo.Texts = "Select Size";

            SeatsText.Texts = "";
			PriceText.Texts = "";
			ModelYearText.Texts = "";
			NameText.Texts = "";
			await UpdateCars();
        }

        private async void IsAutomatic_CheckedChanged(object sender, EventArgs e)
        {
            IsAutomaticToggleChange = true;
            await UpdateCars();
        }

        private void Frm_List_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
            {
                SizeCombo.Items.Add(((RentalStatus)i));
            }
        }
    }
}
