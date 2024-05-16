namespace CarRental.UI.Models.Account
{
    public class SettingsViewModel
    {
        public ProfileDetailsViewModel ProfileDetails { get; set; }  = new ProfileDetailsViewModel();

        public PasswordChangeViewModel? PasswordChange { get; set; }
    }
}
