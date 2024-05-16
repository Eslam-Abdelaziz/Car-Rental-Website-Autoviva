using AdminPanel.Extenstions;
using AdminPanel.Models.Entities;
using AdminPanel.Models.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace AdminPanel.Services
{
    public class RentalService
    {
        private ConnectionService _connectionService;

        public RentalService(ConnectionService connectionService)
        {
            _connectionService = connectionService;
        }

        public async Task<List<Rental>> GetAsync(RentalSearchRequest req)
        {
            return await _connectionService.PostJsonAsync<List<Rental>>($"api/Rentals/Search",req);
        }
        public async Task<int> GetTotalAsync() 
        {
            try
            {
               var res =  await _connectionService.GetStringAsync($"api/Rentals/Total");
                if (int.TryParse(res,out int re)) 
                {
                    return re;
                }
            }
            catch (Exception)
            {

            }
            return 0;
        }
        public async Task<bool> EditAsync(int id,int rentalStatus,int paymentStatus)
        {
            (bool res,string msg) = await _connectionService.PutAsync($"api/Rentals/{id}",new EditRentalReq() 
            {
                Id = id ,
                RentalStatus = (Models.RentalStatus)rentalStatus,
                PaymentStatus = (Models.PaymentStatus)paymentStatus,
            });

            if (res)
            {
                MessageBox.Show("Edit Successfully !");
                return true;
            }
            else
            {
                MessageBox.Show(msg, "Edit Failed ");
                return false;
            }
        }
    }
}
