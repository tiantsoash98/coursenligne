using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ASTEK.Architecture.Infrastructure.Validator.Concrete
{
    public class ContentValidator : AbstractValidator<string>
    {
        public const int MinLength = 5;

        public ContentValidator()
        {
            RuleFor(obj => obj)
                .NotEmpty()
                .WithMessage(x => string.Format(InfrastructureStrings.Property_IsNotNullOrWhiteSpace, InfrastructureStrings.Display_Content));

            RuleFor(obj => obj)
                .MinimumLength(MinLength)
                .WithMessage(x => string.Format(InfrastructureStrings.Property_MinimumLength, InfrastructureStrings.Display_Content, MinLength))
                .When(obj => !string.IsNullOrEmpty(obj));
        }
    }
}
