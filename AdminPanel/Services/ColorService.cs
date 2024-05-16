using AdminPanel.Extenstions;
using AdminPanel.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminPanel.Services
{
    public class ColorService
    {
        private ConnectionService _connectionService;

        public ColorService(ConnectionService connectionService)
        {
            _connectionService = connectionService;
        }
        public async Task<List<Color>> GetColorsAsync() 
        {
            return await _connectionService.GetJsonAsync<List<Color>>("api/Colors");
        }
        public async Task<bool> AddColor(string Name)
        {
            try
            {
                var res = await _connectionService.PostAsync($"api/Colors?name={Name}", null);
                if (res.IsSuccessStatusCode)
                {
                    MessageBox.Show("Color Added !");
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
                MessageBox.Show(ex.Message, "Error.");
                return false;

            }

        }
        public async Task<bool> EditColor(int id, string Name)
        {
            try
            {
                var res = await _connectionService.PutAsync($"api/Colors/{id}?name={Name}", null);
                if (res.IsSuccessStatusCode)
                {
                    MessageBox.Show("Color Edited Successffuly !");
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
