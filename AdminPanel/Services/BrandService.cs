using AdminPanel.Extenstions;
using AdminPanel.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminPanel.Services
{
    public class BrandService
    {
        private ConnectionService _connectionService;

        public BrandService(ConnectionService connectionService)
        {
            _connectionService = connectionService;
        }

        public async Task<List<Brand>> GetBrandsAsync() 
        {
           return await _connectionService.GetJsonAsync<List<Brand>>("api/Brands") ?? new List<Brand>();
        }
        public async Task<bool> AddBrand(string Name) 
        {
            try
            {
                var res = await _connectionService.PostAsync($"api/Brands?Name={Name}", null);
                if (res.IsSuccessStatusCode)
                {
                    MessageBox.Show("Brand Added !");
                    return true;
                }
                else
                {
                    MessageBox.Show("Add Failed !");
                    return false;
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message,"Error.");
                return false;

            }

        }
        public async Task<bool> EditBrand(int id ,string Name) 
        {
            try
            {
                var res = await _connectionService.PutAsync($"api/Brands?id={id}&name={Name}", null);
                if (res.IsSuccessStatusCode)
                {
                    MessageBox.Show("Brand Edited Successffuly !");
                    return true;
                }
                else
                {
                    MessageBox.Show("Edit Failed !");
                    return false;

                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "Error.");
                return false;

            }

        }
    }
}
