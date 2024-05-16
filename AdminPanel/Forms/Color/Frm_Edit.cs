using AdminPanel.Services;
using System;
using System.Windows.Forms;

namespace AdminPanel.Forms.Color
{
    public partial class Frm_Edit : Form
    {
        private Frm_List Frm_List;
        private readonly Models.Color _color;

        private readonly ColorService _colorService;
        public Frm_Edit(Frm_List frm_List, ColorService colorService, Models.Color color)
        {
            InitializeComponent();
            Frm_List = frm_List;
            _color = color;
            _colorService = colorService;
        }

        private async void EditBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ColorText.Texts)) 
            {
                MessageBox.Show("Please Add Name");
                return;
            }
            if (await _colorService.EditColor(_color.Id,ColorText.Texts)) 
            {
                Frm_List.UpdateColors();
                this.Close();
            }
        }

        private void Frm_Edit_Load(object sender, EventArgs e)
        {
            ColorText.Texts = _color.Name;
        }
    }
}
