using AdminPanel.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Forms;

namespace AdminPanel.Forms
{
    public partial class Frm_Statistics : Form
    {
        private List<Panel> rentalPanels;
        private List<Panel> revenuPanels;
        private List<Panel> generalPanels;
        private UserService userService;

        public Frm_Statistics(UserService userService)
        {
            InitializeComponent();
            rentalPanels = new List<Panel>()
            {
                PanelTotalRentals,
                PanelCompletedRentals,
                PanelPendingRentals,
                PanelRejectedRentals,
            };

            revenuPanels = new List<Panel>()
            {
                PanelTotalRevenue,
                PanelPendingRevenue,
                PanelMonthRevenue,
                PanelWeakRevenue
            };
            generalPanels = new List<Panel>()
            {
                PanelCars,
                PanelUsers,
                PanelBranches,
                PanelBrands
            };
            this.userService = userService;
        }
        protected async override void OnVisibleChanged(EventArgs e)
        {
            if (Visible)
            {
                await UpdateStatistics(default,DateTime.Today);
            }
            base.OnVisibleChanged(e);
        }

        private async Task UpdateStatistics(DateTime from,DateTime to)
        {
            var res = await userService.GetStatisticsAsync(from, to);
            LblCompletedRentals.Text = res.TotalCompletedRentals.ToString();
            LblPendingRentals.Text = res.TotalPendingRentals.ToString();
            LblRejectedRentals.Text = res.TotalRejectedRentals.ToString();
            LblTotalRentals.Text = res.TotalRentals.ToString();


            LblTotalRevenue.Text = res.TotalRevenue.ToString();
            LblRejectedRevenue.Text = res.TotalRejectedRevenue.ToString();
            LblPendingRevenue.Text = res.TotalPendingRevenue.ToString();
            LblCompletedRevenue.Text = res.TotalCompletedRevenue.ToString();


            LblCars.Text = res.Cars.ToString();
            LblBranches.Text = res.Branches.ToString();
            LblBrands.Text = res.Brands.ToString();
            LblUsers.Text = res.Users.ToString();

        }

        private void Frm_Statistics_SizeChanged(object sender, EventArgs e)
        {
            label3.Left = (this.ClientSize.Width - label3.Size.Width) / 2;
            // Calculate the panel width based on the form size and spacing

            if (rentalPanels != null)
            {
                AdjustPanels(rentalPanels);
            }


            if (revenuPanels != null)
            {
                AdjustPanels(revenuPanels);
                lblFrom.Left = revenuPanels[2].Left;
                FromDatePicker.Left = revenuPanels[2].Left;
                FromDatePicker.Size = revenuPanels[2].Size;
                LblTo.Left = revenuPanels[3].Left;
                ToDatePicker.Left = revenuPanels[3].Left;
                ToDatePicker.Size = revenuPanels[3].Size;

            }

            if (generalPanels != null)
            {
                AdjustPanels(generalPanels);
            }

    

    
            ToDatePicker.Update();
            FromDatePicker.Update();
        }

        private void AdjustPanels(List<Panel> panels) 
        {
            int panelWidth = (this.ClientSize.Width - 2 * 10 - (panels.Count - 1) * 30) / panels.Count;

            // Update the panel widths and positions
            for (int i = 0; i < panels.Count; i++)
            {
                panels[i].Size = new Size(panelWidth, panels[i].Height);
                panels[i].Location = new Point(10 + (panelWidth + 30) * i, panels[i].Location.Y);
            }
        }

        private async void FromDatePicker_ValueChanged(object sender, EventArgs e)
        {
            if (FromDatePicker.Value > ToDatePicker.Value) 
            {
                FromDatePicker.Value = ToDatePicker.Value;
            }
            await UpdateStatistics(FromDatePicker.Value, ToDatePicker.Value);
        }

        private async void ToDatePicker_ValueChanged(object sender, EventArgs e)
        {
            if (ToDatePicker.Value < FromDatePicker.Value)
            {
                ToDatePicker.Value = FromDatePicker.Value;
            }
            await UpdateStatistics(FromDatePicker.Value, ToDatePicker.Value);
        }

        private void Frm_Statistics_Load(object sender, EventArgs e)
        {

        }
    }
}
