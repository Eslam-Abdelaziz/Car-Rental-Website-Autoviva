using CarRental.Data.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Application.Contracts.Entities
{
    public interface IPaymentService :  IGenericRepository<Payment>
    {
    }
}
