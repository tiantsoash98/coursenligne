using FluentValidation;
using System.Text.RegularExpressions;

namespace ASTEK.Architecture.Infrastructure.Validator.Concrete
{
    public class AddressValidator: AbstractValidator<string>
    {
        //Can only contain :
        //-alphanumerics
        //-whitespaces
        //-hyphens
        public const string RegexPattern = "^[a-zA-Z0-9][a-zA-Z0-9\\s-]+$";

        public AddressValidator()
        {
            RuleFor(obj => obj)
                .NotEmpty()
                .WithMessage(x => string.Format(InfrastructureStrings.Property_IsNotNullOrWhiteSpace, InfrastructureStrings.Display_Address));

            RuleFor(obj => obj)
                .Must(AddressFormat)
                .WithMessage(obj => string.Format(InfrastructureStrings.Property_InvalidFormat, obj, InfrastructureStrings.Display_Address.ToLower()));
        }

        private bool AddressFormat(string name)
        {
            return Regex.IsMatch(name, RegexPattern);
        }
    }
}
