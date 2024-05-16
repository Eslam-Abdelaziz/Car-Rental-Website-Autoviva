using AdminPanel.Extenstions;
using AdminPanel.Models;
using AdminPanel.Models.Requests;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AdminPanel.Services
{
    public class ModelService
    {
        private ConnectionService _connectionService;

        public ModelService(ConnectionService connectionService)
        {
            _connectionService = connectionService;
        }

        public async Task<List<Model>> Get(int id) 
        {
            return await _connectionService.GetJsonAsync<List<Model>>($"api/Model?id={id}");
        }

        public async Task<bool> Add(AddModelReq req) 
        {
            (bool success , string error ) = await _connectionService.PostAsyncEx($"api/Model", req);
            return success;
        }
        public async Task<bool> Edit(EditModelReq req) 
        {
            (bool success, string error) = await _connectionService.PutAsync($"api/Model", req);
            return success;
        }
    }
}
