using CarRental.Data.DTO.Requests;
using FluentValidation;
using FluentValidation.Results;

namespace CarRental.Application.Validation.Implementaions
{
    public class AuthValidator : AbstractValidator<UserRegistarDTO>
    {
        public override ValidationResult Validate(ValidationContext<UserRegistarDTO> context)
        {
            var result = base.Validate(context);
            if (result.Errors.Count > 1)
            {
                for (var i = 1; i < result.Errors.Count; i++)
                {
                    result.Errors.RemoveAt(i);
                }
            }

            return result;
        }

        public override async Task<ValidationResult> ValidateAsync(ValidationContext<UserRegistarDTO> context, CancellationToken cancellation = new CancellationToken())
        {
            var result = await base.ValidateAsync(context, cancellation);
            if (result.Errors.Count > 1)
            {
                for (var i = 1; i < result.Errors.Count; i++)
                {
                    result.Errors.RemoveAt(i);
                }
            }

            return result;
        }
        public AuthValidator()
        {
            RuleFor(a => a.Email).NotEmpty().NotNull().EmailAddress();

            RuleFor(a => a.FirstName).NotEmpty().NotNull();

            RuleFor(a => a.LastName).NotEmpty().NotNull();

            RuleFor(a => a.Password).NotEmpty().NotNull().MinimumLength(8);
            RuleFor(a => a.Password).Must(UpperChar).WithMessage("Password must contain at least one capital letter");
            RuleFor(a => a.Password).Must(LowerChar).WithMessage("Password must contain at least one lowercase letter");
            RuleFor(a => a.Password).Must(NumberChar).WithMessage("Password must contain at least one digit");
            RuleFor(a => a.Password).Must(SpecialChar).WithMessage("Password must contain at least one special character");
        }

        private bool UpperChar(string arg)
        {
            char[] upperCaseChacters = new char[]
            {
                'Q','W','E','R','T','Y','U','I',
                'O','P','A','S','D','F','G','H',
                'J','K','L','Z','X','C','V','B',
                'N','M'
            };

            return ForController(arg, upperCaseChacters);
        }

        private bool LowerChar(string arg)
        {
            char[] lowerCaseChacters = new char[]
            {
                'q','w','e','r','t','y','u','i',
                'o','p','a','s','d','f','g','h',
                'j','k','l','z','x','c','v','b',
                'n','m',
            };

            return ForController(arg, lowerCaseChacters);
        }

        private bool NumberChar(string arg)
        {
            char[] numberCharacters = new char[]
            {
                '0','1','2','3','4',
                '5','6','7','8','9',
            };

            return ForController(arg, numberCharacters);
        }


        private bool SpecialChar(string arg)
        {
            char[] specialCharacters = new char[]
            {
                '@', '/', '\\', '_', '-','!','^',
                '+','$','%','½','&','{','}',
                '[',']','(',')','=','?','*',
                '€',';',':',',','.','<','>',
                '"','\'','#'
            };

            return ForController(arg, specialCharacters);
        }


        private bool ForController(string arg, char[] chars)
        {
            foreach (char i in arg)
            {
                foreach (char j in chars)
                {
                    if (i == j)
                    {
                        return true;
                    }
                }
            }

            return false;
        }
    }

}
