using AdminPanel.Models;
using AdminPanel.Services;
using RJCodeAdvance.RJControls;
using System;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminPanel.Forms.Rental
{
	public partial class Frm_List : Form
    {

        private RentalService _rentalService;
        private CarService _carService;
        public Frm_List(RentalService rentalService, CarService carService)
        {
            InitializeComponent();

            ImageList imgList = new ImageList();
            imgList.ImageSize = new Size(1, 50);
            ListRentals.SmallImageList = imgList;
            _rentalService = rentalService;
            ToDatePicker.Value = DateTime.Today;
            FromDatePicker.Value = DateTime.Today.AddDays(-10);
            _carService = carService;
        }
        protected async override void OnVisibleChanged(EventArgs e)
		{
			if (Visible)
			{
                await UpdateRentals();
                lblRentals.Text = $"Rentals : {await _rentalService.GetTotalAsync()}";
            }
            base.OnVisibleChanged(e);
		}
		internal async Task UpdateRentals()
        {
            var req = new Models.Requests.RentalSearchRequest()
            {
                Email = EmailText.Texts,
                Username = NameText.Texts,
                To = ToDatePicker.Value,
                From = FromDatePicker.Value,
            };

            if (RentalCombo.SelectedIndex == -1) 
            {
                req.RentalStatus = null;
            }
            else 
            {
                req.RentalStatus = RentalCombo.SelectedIndex;
            }
            if (decimal.TryParse(PriceText.Texts,out decimal price)) 
            {
                req.Price = price;
            }
            var rentals = await _rentalService.GetAsync(req);
            ListRentals.Items.Clear();

            if (rentals == null) 
            {
                return;
            }
            var Items = rentals.Select(rental =>
            {
                var item = new ListViewItem(rental.User.ToString());
                item.SubItems.Add(rental.Car.Name);
                item.SubItems.Add(rental.RentDate.ToString("dddd, dd MMMM yyyy h:mm tt"));
                item.SubItems.Add(rental.ReturnDate.ToString("dddd, dd MMMM yyyy h:mm tt"));
                item.SubItems.Add(rental.Status.ToString());
                item.SubItems.Add(rental.Payment.Type.ToString());
                item.SubItems.Add(rental.ReturnBranch.Name);
                item.SubItems.Add(rental.Payment.TotalPrice.ToString());
                item.Tag = rental;
                return item;
            });
            ListRentals.Items.AddRange(Items.ToArray());
        }



        private void LogBtn_Click(object sender, System.EventArgs e)
        {
            //Frm_Add frm = new Frm_Add(this,_brandService);
            //frm.ShowDialog();
        }

        private void Frm_List_Load(object sender, EventArgs e)
		{
            for (int i = 0; i < 5; i++)
            {
                RentalCombo.Items.Add(((RentalStatus)i));
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ListRentals.SelectedIndices.Count != 1)
            {
                MessageBox.Show("Please Select A Rental");
                return;
            }
            new Frm_Edit(this,(Models.Entities.Rental)ListRentals.SelectedItems[0].Tag, _rentalService)
               .ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ListRentals_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private async void RentalCombo_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            await UpdateRentals();
        }

        private void PaymentCombo_OnSelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private async void FromDatePicker_ValueChanged(object sender, EventArgs e)
        {
            if (FromDatePicker.Value > ToDatePicker.Value)
            {
                FromDatePicker.Value = ToDatePicker.Value;
            }
            await UpdateRentals();
        }

        private async void ToDatePicker_ValueChanged(object sender, EventArgs e)
        {
            if (ToDatePicker.Value < FromDatePicker.Value)
            {
                ToDatePicker.Value = FromDatePicker.Value;
            }
            await UpdateRentals();
        }

        private async void EmailText__TextChanged(object sender, EventArgs e)
        {
            await UpdateRentals();
        }

        private async void PriceText__TextChanged(object sender, EventArgs e)
        {
            await UpdateRentals();

        }

        private async void NameText__TextChanged(object sender, EventArgs e)
        {
            await UpdateRentals();

        }

        private void Frm_List_SizeChanged(object sender, EventArgs e)
        {
            if (NameText.Left < 55) 
            {
                
                NameText.Size = new Size(NameText.Width -(55 - NameText.Left), NameText.Size.Height);
                NameText.Left = 55;
            }
        }

        private void viewCarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ListRentals.SelectedIndices.Count != 1)
            {
                MessageBox.Show("Please Select A Rental");
                return;
            }
            var rental = (Models.Entities.Rental)ListRentals.SelectedItems[0].Tag;
            new Car.Frm_View(_carService, rental.Car)
               .ShowDialog();
        }

        private void viewUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ListRentals.SelectedIndices.Count != 1)
            {
                MessageBox.Show("Please Select A Rental");
                return;
            }
            var rental = (Models.Entities.Rental)ListRentals.SelectedItems[0].Tag;
            new User.Frm_ViewUser(rental.User)
               .ShowDialog();
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
    }
}
