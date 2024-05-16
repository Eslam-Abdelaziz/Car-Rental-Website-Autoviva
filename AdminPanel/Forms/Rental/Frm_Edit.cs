using AdminPanel.Models;
using AdminPanel.Services;
using System;
using System.Windows.Forms;

namespace AdminPanel.Forms.Rental
{
    public partial class Frm_Edit : Form
    {
        private Frm_List Frm_List;
        private readonly Models.Entities.Rental rental;
        private readonly RentalService rentalService;

        public Frm_Edit(Frm_List frm_List, Models.Entities.Rental rental, RentalService rentalService)
        {
            InitializeComponent();
            Frm_List = frm_List;
            this.rental = rental;
            this.rentalService = rentalService;
            for (int i = 0; i < 5; i++)
            {
                ComboStatus.Items.Add((RentalStatus)i);
            }
            for (int i = 0; i < 3; i++)
            {
                PaymentCombo.Items.Add((PaymentStatus)i);
            }
            ComboStatus.SelectedIndex = ((int)rental.Status);
            PaymentCombo.SelectedIndex = ((int)rental.Payment.Status);

        }

        private async void EditBtn_Click(object sender, EventArgs e)
        {
  
            if (await rentalService.EditAsync(rental.Id, PaymentCombo.SelectedIndex, ComboStatus.SelectedIndex))
            {
                await Frm_List.UpdateRentals();
                Close();
            }
        }

        private void Frm_Edit_Load(object sender, EventArgs e)
        {
        }
    }
}
