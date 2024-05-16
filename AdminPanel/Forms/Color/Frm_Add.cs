using AdminPanel.Services;
using System;
using System.Windows.Forms;

namespace AdminPanel.Forms.Color
{
    public partial class Frm_Add : Form
    {
        private Frm_List Frm_List;
        private readonly ColorService _colorService;
        public Frm_Add(Frm_List frm_List, ColorService colorService)
        {
            InitializeComponent();
            Frm_List = frm_List;
            _colorService = colorService;
        }

        private async void AddBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ColorText.Texts)) 
            {
                MessageBox.Show("Please Add Name");
                return;
            }
            if (await _colorService.AddColor(ColorText.Texts)) 
            {
                Frm_List.UpdateColors();
                this.Close();
            }
        }
    }
}
