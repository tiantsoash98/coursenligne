using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ASTEK.Architecture.Infrastructure.Validator.Concrete
{
    public class DescriptionValidator : AbstractValidator<string>
    {
        public const int MinLength = 5;
        public const int MaxLength = 2000;


        public DescriptionValidator()
        {
            RuleFor(obj => obj)
                .NotEmpty()
                .WithMessage(x => string.Format(InfrastructureStrings.Property_IsNotNullOrWhiteSpace, InfrastructureStrings.Display_Description));

            RuleFor(obj => obj)
                .MinimumLength(MinLength)
                .WithMessage(x => string.Format(InfrastructureStrings.Property_MinimumLength, InfrastructureStrings.Display_Description, MinLength))
                .When(obj => !string.IsNullOrEmpty(obj));
                

            RuleFor(obj => obj)
                .MaximumLength(MaxLength)
                .WithMessage(x => string.Format(InfrastructureStrings.Property_MaximumLength, InfrastructureStrings.Display_Description, MaxLength))
                .When(obj => !string.IsNullOrEmpty(obj));
        }
    }
}
