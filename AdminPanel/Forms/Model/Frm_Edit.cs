using AdminPanel.Services;
using System;
using System.Windows.Forms;

namespace AdminPanel.Forms.Model
{
    public partial class Frm_Edit : Form
    {
        private Frm_List Frm_List;
        private readonly Models.Model _model;
        private ModelService _modelService;
        private Models.Brand _brand;
        public Frm_Edit(Frm_List frm_List, ModelService modelService, Models.Brand brand, Models.Model model)
        {
            InitializeComponent();
            Frm_List = frm_List;
            _modelService = modelService;
            _brand = brand;
            _model = model;
            Text = $"Edit Model => {_model.Name} for Brand {_brand.Name}";

        }

        private async void EditBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ModelText.Texts)) 
            {
                MessageBox.Show("Please Add Name");
                return;
            }
            if (await _modelService.Edit(new Models.Requests.EditModelReq() 
            {
                BrandId = _brand.Id,
                Id = _model.Id,
                Name = ModelText.Texts,
            }))
            {
                await Frm_List.UpdateColors();
                Close();
            }
        }

        private void Frm_Edit_Load(object sender, EventArgs e)
        {
            ModelText.Texts = _model.Name;
        }
    }
}
