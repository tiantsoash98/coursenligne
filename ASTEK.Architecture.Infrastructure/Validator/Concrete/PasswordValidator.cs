using ASTEK.Architecture.Infrastructure.Utility;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ASTEK.Architecture.Infrastructure.Validator.Concrete
{
    public class PasswordValidator: AbstractValidator<string>
    {
        // Does not contain whitespace
        // At least one decimal
        // At least a lower case
        // At least a uppercase
        public const string RegexPattern = "((?!.* )(?=.*\\d)(?=.*[a-z])(?=.*[A-Z]).)";

        public PasswordValidator()
        {
            RuleFor(obj => obj)
                .Must(StringUtilities.IsNotNullOrWhiteSpace)
                .WithMessage(x => string.Format(InfrastructureStrings.Property_IsNotNullOrWhiteSpace, InfrastructureStrings.Display_Password));

            RuleFor(obj => obj)
                .Must(MinimumLength)
                .WithMessage(x => string.Format(InfrastructureStrings.Property_MinimumLength, InfrastructureStrings.Display_Password, ConfigurationManager.AppSettings.Get("passwordLength")));

            RuleFor(obj => obj)
                .Must(PasswordFormat)
                .WithMessage(x => string.Format(InfrastructureStrings.Password_InvalidFormat));
        }


        private bool MinimumLength(string password)
        {
            return StringUtilities.MinimumLength(password, 
                Convert.ToInt32(ConfigurationManager.AppSettings.Get("passwordLength")));
        }

        private bool PasswordFormat(string password)
        {   
            return Regex.IsMatch(password, RegexPattern);
        }
    }
}
