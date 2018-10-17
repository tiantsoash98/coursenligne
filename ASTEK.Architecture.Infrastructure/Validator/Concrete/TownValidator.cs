using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ASTEK.Architecture.Infrastructure.Validator.Concrete
{
    public class TownValidator : AbstractValidator<string>
    {
        //Can only contain :
        //-alphanumerics
        //-whitespaces
        //-hyphens
        public const string RegexPattern = "^[a-zA-Z][a-zA-Z\\s-]+$";

        public TownValidator()
        {
            RuleFor(obj => obj)
                .NotEmpty()
                .WithMessage(x => string.Format(InfrastructureStrings.Property_IsNotNullOrWhiteSpace, InfrastructureStrings.Display_Town));

            RuleFor(obj => obj)
                .Must(TownFormat)
                .WithMessage(obj => string.Format(InfrastructureStrings.Property_InvalidFormat, obj, InfrastructureStrings.Display_Town.ToLower()));
        }

        private bool TownFormat(string name)
        {
            return Regex.IsMatch(name, RegexPattern);
        }
    }
}
