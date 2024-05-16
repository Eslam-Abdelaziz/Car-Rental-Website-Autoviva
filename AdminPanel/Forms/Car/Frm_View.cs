using AdminPanel.Services;
using AdminPanel.UI;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace AdminPanel.Forms.Car
{
	public partial class Frm_View : Form
    {
        private Frm_List Frm_List;

        private Models.Car _car;
		private CarService _carService;

		public Frm_View(CarService carService, Models.Car car)
		{
			InitializeComponent();
			_car = car;
			_carService = carService;
		}
        private async void Frm_Add_Load(object sender, EventArgs e)
        {
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
            CarView.CarName(_car.Name);
			CarView.DailyPrice(_car.DailyPrice.ToString());
			CarView.ModelYear(_car.ModelYear.ToString());
			CarView.IsElectric(_car.IsElectric);
            CarView.Seats(_car.Seats);
            CarView.Color(_car.Color); 
            CarView.Branch(_car.Branch);
			CarView.FuelUsage(_car.FuelUsage);
			CarView.IsAutomatic(_car.IsAutomatic);
			CarView.Model(_car.Model);
			CarView.Brand(_car.Brand);
			CarView.CarSize(_car.Size);
		}

	}
}
