using CarRental.Data.DTO.Entities;

namespace CarRental.Data.DTO.Responses
{
    public class LoginResponse
    {
        public string Token { get; set; }
        public UserDto User { get; set; }

        public bool IsAdmin { get; set; }
    }
}
