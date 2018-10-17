using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ASTEK.Architecture.Infrastructure.Validator.Concrete
{
    public class TitleValidator : AbstractValidator<string>
    {
        //Must start with a letter
        //can only contain :
        // -letter (uppercase and lowercase)
        // -whitespace
        // -hypen
        public const string RegexPattern = "(^([a-zA-Z0-9]))";
        public const int MinLength = 5;
        public const int MaxLength = 200;


        public TitleValidator()
        {
            RuleFor(obj => obj)
                .NotEmpty()
                .WithMessage(x => string.Format(InfrastructureStrings.Property_IsNotNullOrWhiteSpace, InfrastructureStrings.Display_Title));

            RuleFor(obj => obj)
                .MinimumLength(MinLength)
                .WithMessage(x => string.Format(InfrastructureStrings.Property_MinimumLength, InfrastructureStrings.Display_Title, MinLength))
                .When(obj => !string.IsNullOrEmpty(obj));

            RuleFor(obj => obj)
                .MaximumLength(MaxLength)
                .WithMessage(x => string.Format(InfrastructureStrings.Property_MaximumLength, InfrastructureStrings.Display_Title, MaxLength))
                .When(obj => !string.IsNullOrEmpty(obj));

            RuleFor(obj => obj)
                .Must(TitleFormat)
                .WithMessage(obj => string.Format(InfrastructureStrings.Property_InvalidFormat, obj, InfrastructureStrings.Display_Title.ToLower()))
                .When(obj => !string.IsNullOrEmpty(obj));
        }

        private bool TitleFormat(string name)
        {
            return Regex.IsMatch(name, RegexPattern);
        }
    }
}
