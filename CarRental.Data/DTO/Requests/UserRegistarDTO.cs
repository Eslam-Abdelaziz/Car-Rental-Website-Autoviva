using System.ComponentModel.DataAnnotations;

namespace CarRental.Data.DTO.Requests
{
    public class UserRegistarDTO
    {
        public string Email { get; set; }

        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
