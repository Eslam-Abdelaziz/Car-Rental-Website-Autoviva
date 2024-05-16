
using System.ComponentModel.DataAnnotations;

namespace CarRental.UI.Models.Account
{
    public class AddressChangeRequest
    {
        [Required]
        public string Street { get; set; }
        [Required]
        public string City { get; set; }

        [Required]

        public string State { get; set; }

        [Required]
        public int ZipCode { get; set; }

        [Required]
        public string Phone { get; set; }

    }
}
