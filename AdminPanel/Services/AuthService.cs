using AdminPanel.Extenstions;
using AdminPanel.Models;
using AdminPanel.Models.Responses;
using System.Threading.Tasks;

namespace AdminPanel.Services
{
	public class AuthService 
    {
        private ConnectionService _connectionService;

        public AuthService(ConnectionService connectionService)
        {
            _connectionService = connectionService;
        }

        public async Task<LoginRes> LoginAsync(string email,string password) 
        {
			var req = new LoginFormReq()
			{
				Email = email,
				Password = password
			};
			return await _connectionService.PostJsonAsync<LoginRes>("api/Admin/Login", req);
        }
        public void SetAuthKey(string key) 
        {
			_connectionService.SetAuth(key);
		}

    }
}
