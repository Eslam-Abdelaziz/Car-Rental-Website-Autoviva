using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace CarRental.UI.Models.Auth
{
    public class ResetPasswordViewModel
    {
        [RegularExpression("^[A-Fa-f0-9]{8}-[A-Fa-f0-9]{4}-[A-Fa-f0-9]{4}-[A-Fa-f0-9]{4}-[A-Fa-f0-9]{12}$", // Regular expression to use for validation
                                     // Error message to display
                   ErrorMessage = "Please use only printable English characters")]
        [Required(ErrorMessage = "Uid Address is required")]
        public string Uid { get; set; }


        [RegularExpression("^[A-Za-z0-9+/=]+$", // Regular expression to use for validation
                                     // Error message to display
                   ErrorMessage = "Please use only printable English characters")]
        [Required(ErrorMessage = "Code is required")]
        public string Code { get; set; }


        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        /// <summary>
        ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
        ///     directly from your code. This API may change or be removed in future releases.
        /// </summary>
        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }


        [ValidateNever]
        public bool IsReset { get; set; }


    }
}
