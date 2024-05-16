using Microsoft.AspNetCore.Components.Web;
using System.ComponentModel.DataAnnotations;

namespace CarRental.UI.Models.Account
{
    public class ProfileDetailsViewModel
    {

        [RegularExpression("^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\\.[a-zA-Z]{2,}$", // Regular expression to use for validation
                                          // Error message to display
             ErrorMessage = "Email address is not valid.")]
        [Required(ErrorMessage = "Email Address is required")]
        [EmailAddress(ErrorMessage = "Email address is not valid.")]
        public string Email { get; set; }

        [RegularExpression("^[A-Za-z]+$", // Regular expression to use for validation
                                          // Error message to display
                   ErrorMessage = "Please use only printable English characters")]
        [Required(ErrorMessage = "First Name is required")]
        [StringLength(50, ErrorMessage = "First Name cannot exceed 50 characters")]
        public string Firstname { get; set; }

        [RegularExpression("^[A-Za-z]+$", // Regular expression to use for validation
                                          // Error message to display
           ErrorMessage = "Please use only printable English characters")]
        [Required(ErrorMessage = "Last Name is required")]
        [StringLength(50, ErrorMessage = "Last Name cannot exceed 50 characters")]
        public string Lastname { get; set; }



        public bool IsEmptyPassword { get; set; }
        public bool IsChanged { get; set; }
        public bool IsEmailChanged { get; set; }

        




    



    }
}
