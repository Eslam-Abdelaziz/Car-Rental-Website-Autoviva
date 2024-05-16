using AdminPanel.Services;
using System;
using System.Windows.Forms;
using AdminPanel.Models.Requests;
namespace AdminPanel.Forms.Model
{
    public partial class Frm_Add : Form
    {
        private Frm_List Frm_List;
        private ModelService _modelService;
        private Models.Brand _brand;

        public Frm_Add(Frm_List frm_List, ModelService modelService, Models.Brand brand)
        {
            InitializeComponent();
            Frm_List = frm_List;
            _modelService = modelService;
            _brand = brand;
            Text = $"Add Model for Brand {_brand.Name}";

        }

        private async void AddBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ModelName.Texts)) 
            {
                MessageBox.Show("Please Add Name");
                return;
            }
            if (await _modelService.Add(new AddModelReq() 
            {
                Id = _brand.Id,
                Name = ModelName.Texts,
            }))
            {
                await Frm_List.UpdateColors();
                Close();
            }
        }
    }
}
