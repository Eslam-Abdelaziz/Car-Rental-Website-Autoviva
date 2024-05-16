using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace CarRental.UI.Models.Auth
{
    public class ResetPasswordReq
    {
        [RegularExpression("^[A-Fa-f0-9]{8}-[A-Fa-f0-9]{4}-[A-Fa-f0-9]{4}-[A-Fa-f0-9]{4}-[A-Fa-f0-9]{12}$", // Regular expression to use for validation
                                     // Error message to display
                   ErrorMessage = "Please use only printable English characters")]
        [Required(ErrorMessage = "uid is required")]
        public string Uid { get; set; }

        [RegularExpression("^[A-Za-z0-9+/=]+$", // Regular expression to use for validation
                                     // Error message to display
                   ErrorMessage = "Please use only printable English characters")]
        [Required(ErrorMessage = "Code is required")]
        public string Code { get; set; }

        [ValidateNever]
        public bool IsReset { get; set; }
    }
}
