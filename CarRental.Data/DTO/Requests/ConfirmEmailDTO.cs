using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Data.DTO.Requests
{
    public class ConfirmEmailDTO
    {
        public string userId { get; set; }
        public string ConfirmCode { get; set; }

    }
}
