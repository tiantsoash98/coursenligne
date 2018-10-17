using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ASTEK.Architecture.Infrastructure.Validator.Concrete
{
    public class PostalCodeValidator: AbstractValidator<string>
    {
        // Can only contain:
        // decimals
        public const string RegexPattern = "(^([0-9])(?!.*[^0-9\\s]))";

        public PostalCodeValidator()
        {
            RuleFor(obj => obj)
               .NotEmpty()
               .WithMessage(x => string.Format(InfrastructureStrings.Property_IsNotNullOrWhiteSpace, InfrastructureStrings.Display_PostalCode));

            RuleFor(obj => obj)
                .Must(PostalCodeFormat)
                .WithMessage(obj => string.Format(InfrastructureStrings.Property_InvalidFormat, obj, InfrastructureStrings.Display_PostalCode.ToLower()));
        }

        public bool PostalCodeFormat(string postalCode)
        {
            return Regex.IsMatch(postalCode, RegexPattern);
        }
    }
}
