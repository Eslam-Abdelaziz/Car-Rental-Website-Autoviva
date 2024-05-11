using CarRental.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Data.Constants
{
    public class Messages
    {
        public static string RegisterSuccess = "User Registered Successfully !";
        public static string UserAlreadyExists = "User Already Exists Try Sign in !";
        public static string RegisterFail = "unknown Error !";

        public static string UserNotFound = "User Was Not Found !";

        public static string BadCreds = "Credentials aren't valid.";
        public static string SuccessfulLogin = "Successful Login!";

        public static string PasswordUpdated = "Password Updated Successfully !";




        public static string WrongOldPassword = "Wrong Old Password !";
        public static string CannotAddPassword = "Cannot Reset Password Error 2";
        public static string ConfirmEmail = "Please Confirm Your Email First.";




        public static string ResetPassword = "a Code Sent to your email.";
        public static string CannotResetPassword = "Cannot Reset Password.";
        public static string InvailedResetCode = "Reset Code is invaild.";
        public static string ResetCodeExpired = "Reset Code is Expired.";

        public static string ResetPasswordGeneric = "Error Occurred.";
        public static string Unknown = "Unknow Error.";

        public static string ColorsNotFound = "Color Not Found.";
    }
}
