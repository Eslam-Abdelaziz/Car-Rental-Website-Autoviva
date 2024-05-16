using AdminPanel.Models;
using AdminPanel.Services;
using RJCodeAdvance.RJControls;
using System;
using System.Windows.Forms;

namespace AdminPanel.Forms.Car
{
    public partial class Frm_Add : Form
    {
        private Frm_List Frm_List;
        private BranchService _branchService;
        private ColorService _colorService;
        private BrandService _BrandService;
        private CarService _carService;
		public Frm_Add(Frm_List frm_List, BranchService branchService, ColorService colorService, BrandService brandService, CarService carService)
		{
			InitializeComponent();
			Frm_List = frm_List;
			_branchService = branchService;
			_colorService = colorService;
			_BrandService = brandService;
			_carService = carService;
		}

		private async void AddBtn_Click(object sender, EventArgs e)
        {
            if(CarView.GetImages().Count < 1) 
            {
                MessageBox.Show
                    ("Please Select Car Images");
                return;
            }

            if (CarView.TryGetCar(out Models.Car car)) 
            {
                car = await _carService.AddCar(car);

				if (car != null) 
                {
                    if (await _carService.PostImages(car,CarView.GetImages()))
                    {
						MessageBox.Show("Car Images Added Successfully.");
					}
					else 
                    {
						MessageBox.Show("Error While Posting Car Images");
					}
					this.Close();
					await Frm_List.UpdateCars();

				}
				else 
                {
                    MessageBox.Show("Error Happend While Adding Car.");
                }
               
            }else 
            {
                MessageBox.Show("Please Validate Input Data","Error.");
            }

        }

        private async void Frm_Add_Load(object sender, EventArgs e)
        {
            var branches = await _branchService.GetBranchesAsync();
            BranchCombo.Items.AddRange(branches.ToArray());

            var brands = await _BrandService.GetBrandsAsync();
            BrandCombo.Items.AddRange(brands.ToArray());

            var colors = await _colorService.GetColorsAsync();
            ColorCombo.Items.AddRange(colors.ToArray());

            for(int i = 0; i < 5; i++) 
            {
                SizeCombo.Items.Add((CarSize)i);
            }

        }


        private void PriceText__TextChanged(object sender, EventArgs e)
        {
            CarView.DailyPrice(PriceText.Texts);
        }

     
        private void ModelYearText__TextChanged(object sender, EventArgs e)
        {
            CarView.ModelYear(ModelYearText.Texts);
        }

        private void IsElectricToggle_CheckedChanged(object sender, EventArgs e)
        {
            CarView.IsElectric(IsElectricToggle.Checked);
        }

        private void PriceText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != '-')
            {
                e.Handled = true;
            }


            // Allow decimal point only if it's not already present in the textbox
            if (e.KeyChar == '.' && (sender as RJTextBox).Texts.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
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
            if(ModelYearText.Texts.Length >= 4) 
            {
                e.Handled = true;
            }
        }

        private void SeatsText__TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(SeatsText.Texts, out int Seats))
            {
                CarView.Seats(Seats);
            }
        }

        private void BrandCombo_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            var brand = (Models.Brand)BrandCombo.SelectedItem;
            ModelCombo.Items.Clear();
            if (brand.Models != null) 
            {
                ModelCombo.Items.AddRange(brand.Models.ToArray());
            }
            CarView.Brand(brand);

        }

        private void SizeCombo_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            CarView.CarSize((CarSize)SizeCombo.SelectedItem);
        }

        private void ColorCombo_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            CarView.Color((Models.Color)ColorCombo.SelectedItem);
        }

        private void ChooseBtn_Click(object sender, EventArgs e)
        {
            using (var op = new OpenFileDialog()) 
            {
                op.Multiselect = true;
                op.Title = "Select Car Images";
                op.Filter = "Image Files|*.bmp;*.jpg;*.jpeg;*.png;*.gif";
                if (op.ShowDialog() == DialogResult.OK) 
                {
                    MessageBox.Show(String.Format("Selected {0} Images !", op.FileNames.Length));
                }
                CarView.CarImages(op.FileNames);
            }
        }

        private void CarView_Load(object sender, EventArgs e)
        {

        }

		private void BranchCombo_OnSelectedIndexChanged(object sender, EventArgs e)
		{
			CarView.Branch((Models.Branch)BranchCombo.SelectedItem);
		}

        private void ModelCombo_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            CarView.Model((Models.Model)ModelCombo.SelectedItem);

        }

        private void IsAutomaticToggle_CheckedChanged(object sender, EventArgs e)
        {
            CarView.IsAutomatic(IsAutomaticToggle.Checked);
        }

        private void FuelUsageText__TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(FuelUsageText.Texts,out double price)) 
            {
                CarView.FuelUsage(price);
            }
        }

        private void FuelUsageText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != '-')
            {
                e.Handled = true;
            }
            // Allow decimal point only if it's not already present in the textbox
            if (e.KeyChar == '.' && (sender as RJTextBox).Texts.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }
    }
}
