using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminPanel.Models.Requests
{
    public class EditRentalReq
    {
        public int Id { get; set; }
        public RentalStatus RentalStatus { get; set; }
        public PaymentStatus PaymentStatus { get; set; }
    }
}
