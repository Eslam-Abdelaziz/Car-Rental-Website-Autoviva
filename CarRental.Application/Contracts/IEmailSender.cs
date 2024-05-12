using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Application.Contracts
{
   public interface  IEmailSender
   {

       Task SendEmailAsync(string email, string subject, string htmlMessage);
       Task SendEmailAsync(string FromAddress ,string email, string subject, string htmlMessage);
   }
}
