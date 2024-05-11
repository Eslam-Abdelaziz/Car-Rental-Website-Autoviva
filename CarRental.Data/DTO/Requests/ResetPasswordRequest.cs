namespace CarRental.Data.DTO.Requests
{
    public class ResetPasswordRequest
    {
        public string Email { get; set; }
        public string RestToken { get; set; }
        public string Password { get; set; }

    }
}
