using AdminPanel.Extenstions;
using AdminPanel.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminPanel.Services
{
    public class BranchService
    {
        private ConnectionService _connectionService;

        public BranchService(ConnectionService connectionService)
        {
            _connectionService = connectionService;
        }

        public async Task<List<Branch>> GetBranchesAsync() 
        {
            return await _connectionService.GetJsonAsync<List<Branch>>("api/Branches") ?? new List<Branch>();
        }
        public async Task<bool> AddBranch(Branch branch) 
        {
           (bool success, string msg) = await _connectionService.PostAsyncEx("api/Branches", branch);

            if (success) 
            {
                MessageBox.Show("Branch Added !");
                return true;
            }
            else 
            {
                MessageBox.Show(msg,"Add Failed");
                return false;
            }
        }
        public async Task<bool> EditBranch(Branch branch) 
        {
            (bool Success , string Msg) = await _connectionService.PutAsync($"api/Branches/{branch.Id}",branch);
            if (Success) 
            {
                MessageBox.Show("Edit Successfully !");
                return true;
            }
            else 
            {
                MessageBox.Show(Msg,"Edit Failed ");
                return false;
            }
        }
    }
}
