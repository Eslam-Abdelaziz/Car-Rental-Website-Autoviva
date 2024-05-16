using System.ComponentModel.DataAnnotations;

namespace CarRental.UI.Models.Auth
{
    public class ForgotPasswordViewModel
    {
        [RegularExpression("^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\\.[a-zA-Z]{2,}$", // Regular expression to use for validation
                                                                                // Error message to display
        ErrorMessage = "Email address is not valid.")]
        [Required(ErrorMessage = "Email Address is required")]
        public string Email { get; set; }

        public bool IsSent { get; set; }
    }
}
