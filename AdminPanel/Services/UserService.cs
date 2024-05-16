using AdminPanel.Extenstions;
using AdminPanel.Models;
using AdminPanel.Models.Requests;
using AdminPanel.Models.Responses;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AdminPanel.Services
{
    public class UserService
    {
        private ConnectionService _connectionService;

        public UserService(ConnectionService connectionService)
        {
            _connectionService = connectionService;
        }

        public async Task<List<User>> GetUsersAsync(string email,string first,string last ,string City,string Phone) 
        {
            var Users = await _connectionService.GetJsonAsync<List<User>>($"api/Users/Search?email={email}&first={first}&last={last}&city={City}&Phone={Phone}");
            return Users;

        }
        public async Task<bool> AddBranchUser(User user , Branch branch) 
        {
            (bool success, string msg) = await _connectionService.PostAsyncEx("api/Users/AddBranchUser", new AddUserBranchReq() { BranchId = branch.Id, UserId = user.Id });
            return success;
        }
        public async Task<bool> DeleteBranchUser(User user) 
        {
            try
            {
                var res = await _connectionService.DeleteAsync($"api/Users/DeleteBranchUser?Userid={user.Id}");
                return res.IsSuccessStatusCode;
            }
            catch (System.Exception)
            {
                return false;
            }
        }

        public async Task<StatisticsResponse> GetStatisticsAsync(DateTime from,DateTime to) 
        {
            return await _connectionService.PostJsonAsync<StatisticsResponse>("api/Users/Statistics",new StatisticsRequest() 
            {
                To = to,
                From = from,
            });
        }
    }
}
