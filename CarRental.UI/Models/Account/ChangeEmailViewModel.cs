using System.ComponentModel.DataAnnotations;

namespace CarRental.UI.Models.Account
{
    public class ChangeEmailViewModel
    {
        //[RegularExpression("^[A-Fa-f0-9]{8}-[A-Fa-f0-9]{4}-[A-Fa-f0-9]{4}-[A-Fa-f0-9]{4}-[A-Fa-f0-9]{12}$", // Regular expression to use for validation
        //                                                                                                    // Error message to display
        //           ErrorMessage = "Please use only printable English characters")]
        [Required(ErrorMessage = "Uid Address is required")]
        public string Uid { get; set; }


        //[RegularExpression("^[A-Za-z0-9+/=]+$", // Regular expression to use for validation
        //                                        // Error message to display
        //           ErrorMessage = "Please use only printable English characters")]
        [Required(ErrorMessage = "Code is required")]
        public string Code { get; set; }

        public bool IsEmailChanged { get; set; }

        //[RegularExpression("^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\\.[a-zA-Z]{2,}$", // Regular expression to use for validation
        //                                                                        // Error message to display
        //     ErrorMessage = "Email address is not valid.")]
        [Required(ErrorMessage = "Email Address is required")]
        [EmailAddress(ErrorMessage = "Email address is not valid.")]
        public string Email { get; set; }
    }
}
