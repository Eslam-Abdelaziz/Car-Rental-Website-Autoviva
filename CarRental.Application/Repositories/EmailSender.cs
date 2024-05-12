using CarRental.Application.Contracts;
using CarRental.Data.Models;
using Microsoft.Extensions.Options;
using System.Net;
using System.Net.Mail;

namespace CarRental.Application.Repositories
{
    public class EmailSender : IEmailSender
    {
        private readonly SmtpClient _smtpClient;
        private readonly MailSettings _mailSettings;

        public EmailSender(IOptions<MailSettings> mailSettings) 
        {
            _mailSettings = mailSettings.Value;
            _smtpClient = new SmtpClient(_mailSettings.Hostname,_mailSettings.Port);
            _smtpClient.EnableSsl = _mailSettings.UseSSL;
            _smtpClient.Credentials = new NetworkCredential(_mailSettings.Username,_mailSettings.Password);
        }

        public async Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            await InternalSendEmailAsync(_mailSettings.FromEmail, email, subject, htmlMessage);
        }

        public async Task SendEmailAsync(string FromAddress, string email, string subject, string htmlMessage)
        {

            await InternalSendEmailAsync(FromAddress,email,subject,htmlMessage);
        }

        public async Task InternalSendEmailAsync(string FromAddress, string email, string subject, string htmlMessage) 
        {
            var message = new MailMessage
            {
                From = new MailAddress(FromAddress),
                Subject = subject,
                Body = htmlMessage,
                IsBodyHtml = true
            };

            message.To.Add(new MailAddress(email));
           await _smtpClient.SendMailAsync(message);
        }
    }
}
