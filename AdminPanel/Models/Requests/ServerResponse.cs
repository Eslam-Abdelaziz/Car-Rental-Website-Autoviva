namespace AdminPanel.Models
{
    public class ServerResponse
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public dynamic data { get; set; }
    }
}
