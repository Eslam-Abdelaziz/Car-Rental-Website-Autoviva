using System.ComponentModel.DataAnnotations;

namespace CarRental.UI.Models.Auth
{
    public class SignUpViewModel
    {
             [RegularExpression("^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\\.[a-zA-Z]{2,}$", // Regular expression to use for validation
                                          // Error message to display
             ErrorMessage = "Email address is not valid.")]
        [Required(ErrorMessage = "Email Address is required")]
        [EmailAddress(ErrorMessage = "Email address is not valid.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [DataType(DataType.Password, ErrorMessage = "Password doesn't meet our password policy")]
        [StringLength(32, MinimumLength = 6, ErrorMessage = "Password must be between 6 and 10 characters")]
        public string Password { get; set; }




        [RegularExpression("^[A-Za-z]+$", // Regular expression to use for validation
                                     // Error message to display
                   ErrorMessage = "Please use only printable English characters")]
        [Required(ErrorMessage = "First Name is required")]
        [StringLength(50, ErrorMessage = "First Name cannot exceed 50 characters")]
        public string FirstName { get; set; }

        [RegularExpression("^[A-Za-z]+$", // Regular expression to use for validation
                                     // Error message to display
                   ErrorMessage = "Please use only printable English characters")]
        [Required(ErrorMessage = "Last Name is required")]
        [StringLength(50, ErrorMessage = "Last Name cannot exceed 50 characters")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "You must agree to the Privacy Policy.")]
        public bool AgreeToPrivacyPolicy { get; set; }
        public string? ReturnUrl { get; set; }
    }
}
