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
    public class NameValidator: AbstractValidator<string>
    {
        //Must start with a letter
        //can only contain :
        // -letter (uppercase and lowercase)
        // -whitespace
        // -hypen
        public const string RegexPattern = "(^([a-zA-Z])(?!.*[^a-zA-Zéè\\s-]))";

        public NameValidator(string display)
        {
            RuleFor(obj => obj)
                .Must(StringUtilities.IsNotNullOrWhiteSpace)
                .WithMessage(x => string.Format(InfrastructureStrings.Property_IsNotNullOrWhiteSpace, display));

            RuleFor(obj => obj)
                .Must(MinimumLength)
                .WithMessage(x => string.Format(InfrastructureStrings.Property_MinimumLength, InfrastructureStrings.Display_Name, ConfigurationManager.AppSettings.Get("nameLength")));

            RuleFor(obj => obj)
                .Must(NameFormat)
                .WithMessage(x => string.Format(InfrastructureStrings.Property_InvalidFormat, x, display.ToLower()));
        }

        private bool MinimumLength(string name)
        {
            return StringUtilities.MinimumLength(name,
                Convert.ToInt32(ConfigurationManager.AppSettings.Get("nameLength")));
        }

        private bool NameFormat(string name)
        {
            return Regex.IsMatch(name, RegexPattern);
        }
    }
}
