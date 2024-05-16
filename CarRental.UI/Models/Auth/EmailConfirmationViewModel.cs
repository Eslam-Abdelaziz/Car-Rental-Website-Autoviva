using CarRental.Data.Models.Entities;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.ComponentModel.DataAnnotations;

namespace CarRental.UI.Models.Auth
{
    public class EmailConfirmationViewModel
    {
        [BindNever]
        public User User { get; set; }



        [BindNever]
        public bool IsResent { get; set; }


        [BindNever]
        public bool IsConfirmed { get; set; }

        [RegularExpression("^[A-Fa-f0-9]{8}-[A-Fa-f0-9]{4}-[A-Fa-f0-9]{4}-[A-Fa-f0-9]{4}-[A-Fa-f0-9]{12}$", // Regular expression to use for validation
                                     // Error message to display
                   ErrorMessage = "Please use only printable English characters")]
        [Required(ErrorMessage = "error happend.")]
        public string Uid { get; set; }


        [RegularExpression("^[A-Za-z0-9+/=]+$")]
        [Required(ErrorMessage = "Confirmation Code is required")]
        [StringLength(8, MinimumLength = 8, ErrorMessage = "Confirmation Code must be 8 Charaters")]
        public string Code { get; set; }
        public string? ReturnUrl { get; set; }

    }
}
