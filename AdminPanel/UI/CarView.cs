using AdminPanel.Extenstions;
using AdminPanel.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace AdminPanel.UI
{
	public partial class CarView : UserControl
    {


        private int _Seats ;
        private int _ModelYear;
        private double _DailyPrice;
        private string _Name = null;
        private bool _IsElectric;
        private bool _isAutomatic;
        private double _fuelUsage;
        private CarSize _CarSize;
        private Models.Color _color = null;
        private Brand _brand = null;
        private Branch _branch = null;
        private Model _model = null;
		private List<Image> _Images = new List<Image>();
        private int SelectedIndex = 0;
        public CarView()
        {
            InitializeComponent();
            this.BackColor = System.Drawing.Color.Transparent;
            NextBtn.BackColor = System.Drawing.Color.Transparent;
            BackBtn.BackColor = System.Drawing.Color.Transparent;
        }
        public void CarName(string name)
        {
			_Name = name;
			NameLbl.Text = name;
        }
  
       
        public void Color(Models.Color color)
        {
            _color  = color;
            ColorLbl.Text = color.Name;
        }
        public void ModelYear(string modelYear)
        {
			 int.TryParse(modelYear,out _ModelYear);
			ModelYearLbl.Text = modelYear;
        }
        public void Seats(int seats)
        {
            SeatsLbl.Text = string.Format("{0} Seats", seats);
            _Seats = seats;
        }
        public void Brand(Brand brand)
        {
            _brand = brand;
            BrandLbl.Text = brand.Name;
            UpdateName();
        }
        public void CarSize(CarSize size)
        {
			_CarSize = size;

			SizeLbl.Text = size.ToString();
        }
        public void DailyPrice(string Price)
        {
            if (double.TryParse(Price, out double Priceex)) 
            {
                _DailyPrice = Priceex;
            }
			PriceLbl.Text = string.Format("{0} LE / Day", Price);
        }
        public void IsElectric(bool isElectric)
        {
            _IsElectric = isElectric;
            LblElectric.Text = (isElectric) ? "Electric" : "Gasoline";
            FuelUsage(_fuelUsage);
        }
        public void Branch(Branch branch) 
        {
            _branch = branch;
        }
        public void CarImages(string[] ImagesPath)
        {
            if (ImagesPath.Length < 1) 
            {
                return;
            }
			_Images.Clear();
            foreach (var imagePath in ImagesPath)
            {
				_Images.Add(Image.FromFile(imagePath));
            }
            CarPicBox.Image = _Images[0].Resize(CarPicBox.Size);
        }

        private void CarView_Load(object sender, System.EventArgs e)
        {

        }
        private void NextBtn_Click(object sender, System.EventArgs e)
        {
            if (_Images.Count == 0 || _Images.Count == 1) 
            {
                return;
            }
            if (SelectedIndex + 1 < _Images.Count) 
            {
                SelectedIndex++;
            }
            else 
            {
                SelectedIndex = 0;
            }
            SelectImage();
        }
        private void SelectImage() 
        {
            if (_Images.Count < 1) 
            {
                return;
            }
            CarPicBox.Image = _Images[SelectedIndex].Resize(CarPicBox.Size);
            CarPicBox.Update();
        }

        private void BackBtn_Click(object sender, System.EventArgs e)
        {
            if (_Images.Count == 0 || _Images.Count == 1)
            {
                return;
            }
            if (SelectedIndex - 1 >= 0)
            {
                SelectedIndex--;
            }
            else
            {
                SelectedIndex = _Images.Count - 1 ;
            }
            SelectImage();
        }
        public bool TryGetCar(out Car car) 
        {
            car = null;
            if (_brand == null) 
            {
                return false;
            }
			if (_branch == null)
			{
				return false;
			}
			if (_color == null)
			{
				return false;
			}
			if (_Name == null)
			{
				return false;
			}
            if (_Seats <= 0) 
            {
                return false;
            }
			if (_DailyPrice <= 0)
			{
				return false;
			}
			if (_ModelYear <= 0)
			{
				return false;
			}
			car = new Car();
            car.Name = _Name;
            car.Brand = _brand;
            car.Branch = _branch;
            car.ModelYear = _ModelYear;
            car.Color = _color;
            car.Size = _CarSize;
            car.Seats = _Seats;
            car.IsElectric = _IsElectric;
            car.IsAutomatic = _isAutomatic;
            car.DailyPrice = (decimal)_DailyPrice;
            car.FuelUsage = _fuelUsage;
            car.Model = _model;
            return true;
        }
        public void Images(List<Image> images) 
        {
            this._Images = images;
            SelectImage();
        }
        public List<Image> GetImages() { return _Images; }

		private void PriceLbl_Click(object sender, System.EventArgs e)
		{

		}

        private void label1_Click(object sender, System.EventArgs e)
        {

        }
        internal void Model(Model selectedItem)
        {
            _model = selectedItem;
            UpdateName();
        }
        
        private void UpdateName()
        {
            NameLbl.Text = string.Format("{0} {1}", _brand?.Name, _model?.Name);
            _Name = string.Format("{0} {1}", _brand?.Name, _model?.Name);
        }

        internal void FuelUsage(double v) 
        {
            _fuelUsage = v;
            string carType = _IsElectric ? "Kwh" : "Litre";
            LblFuelUsage.Text = string.Format("{0} / 1-{1}",_fuelUsage, carType);
        }
        internal void IsAutomatic(bool check)
        {
            _isAutomatic = check;
            LblAutomatic.Text = check ? "Automatic" : "Manual";
        }
    }
}
