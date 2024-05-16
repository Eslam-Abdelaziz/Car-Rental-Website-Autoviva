using AdminPanel.Extenstions;
using AdminPanel.Models;
using AdminPanel.Services;
using RJCodeAdvance.RJControls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace AdminPanel.Forms.Car
{
    public partial class Frm_Edit : Form
    {
        private Frm_List Frm_List;
        private BranchService _branchService;
        private ColorService _colorService;
        private BrandService _BrandService;
        private Models.Car _car;
		private CarService _carService;

		public Frm_Edit(Frm_List frm_List, BranchService branchService, ColorService colorService, BrandService brandService, CarService carService, Models.Car car)
		{
			InitializeComponent();
			Frm_List = frm_List;
			_branchService = branchService;
			_colorService = colorService;
			_BrandService = brandService;
			_car = car;
			_carService = carService;
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

            List<Image> imgs = new List<Image>();
            foreach(var img  in _car.CarImages) 
            {
                var LoadedImg = await _carService.GetImageAsync(_car.Id, img.Id);
                if (LoadedImg != null)
				{
					imgs.Add(LoadedImg);
				}
			}
            CarView.Images(imgs);
            PriceText.Texts = _car.DailyPrice.ToString();
            ModelYearText.Texts = _car.ModelYear.ToString();
            IsElectricToggle.Checked = _car.IsElectric;
            IsAutomaticToggle.Checked = _car.IsAutomatic;
            FuelUsageText.Texts = _car.FuelUsage.ToString();
            SeatsText.Texts = _car.Seats.ToString();
            BranchCombo.SelectItem(_car.Branch);
            BrandCombo.SelectItem(_car.Brand);
            ModelCombo.Items.Clear();
            ModelCombo.Items.AddRange(brands.First(x=>x.Id == _car.Brand.Id).Models.ToArray());
            ColorCombo.SelectItem(_car.Color);
			ModelCombo.SelectItem(_car.Model);
            SizeCombo.SelectedIndex = (int)_car.Size;

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

        private void SeatsText__TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(SeatsText.Texts, out int Seats))
            {
                CarView.Seats(Seats);
            }
        }

        private void BrandCombo_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            CarView.Brand((Models.Brand)BrandCombo.SelectedItem);
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
       
        private async void EditBtn_Click(object sender, EventArgs e)
		{
            if (CarView.TryGetCar(out Models.Car car)) 
            {
                car.Id = _car.Id;

                bool success =  await _carService.EditCar(car);
                if (success) 
                {
                    if(await _carService.PostImages(car, CarView.GetImages(), true)) 
                    {
                        MessageBox.Show("Images Edited Successfully.");
                    }
                    else 
                    {
						MessageBox.Show("Error Editing Images.");

					}
					this.Close();
                }
                await Frm_List.UpdateCars();

			}
		}

        private void BrandCombo_OnSelectedIndexChanged_1(object sender, EventArgs e)
        {
            var brand = (Models.Brand)BrandCombo.SelectedItem;
            ModelCombo.Items.Clear();
            if (brand.Models != null)
            {
                ModelCombo.Items.AddRange(brand.Models.ToArray());
            }
            CarView.Brand(brand);
        }

        private void IsAutomaticToggle_CheckedChanged(object sender, EventArgs e)
        {
            CarView.IsAutomatic(IsAutomaticToggle.Checked);
        }

        private void FuelUsageText__TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(FuelUsageText.Texts, out double price))
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

        private void ModelCombo_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            CarView.Model((Models.Model)ModelCombo.SelectedItem);
        }
    }
}
