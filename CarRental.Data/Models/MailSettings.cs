namespace CarRental.Data.Models
{
    public class MailSettings
    {
        public string Hostname { get; set; }
        public string Password { get; set; }
        public string Username { get; set; }
        public int Port { get; set; }
        public bool UseSSL { get; set; }
        public string FromEmail { get; set; }
    }
}
