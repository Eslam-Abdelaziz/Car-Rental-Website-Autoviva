using Microsoft.AspNetCore.Identity.UI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Services.Mail
{
    internal class EmailSender : IEmailSender
    {
        private string smtpServer;
        private int smtpPort;
        private string fromEmailAddress;

        public EmailSender(string smtpServer, int smtpPort, string fromEmailAddress)
        {
            this.smtpServer = smtpServer;
            this.smtpPort = smtpPort;
            this.fromEmailAddress = fromEmailAddress;
        }
        public async Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            var message = new MailMessage
            {
                From = new MailAddress(fromEmailAddress),
                Subject = subject,
                Body = htmlMessage,
                IsBodyHtml = true
            };

            message.To.Add(new MailAddress(email));

            using var client = new SmtpClient(smtpServer, smtpPort);

            await client.SendMailAsync(message);
        }
    }
}
