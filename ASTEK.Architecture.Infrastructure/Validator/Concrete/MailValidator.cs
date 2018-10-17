using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASTEK.Architecture.Infrastructure.Validator.Concrete
{
    public class MailValidator : AbstractValidator<string>
    {
        public MailValidator()
        {
            RuleFor(obj => obj)
                .NotEmpty()
                .WithMessage(x => string.Format(InfrastructureStrings.Property_IsNotNullOrWhiteSpace, InfrastructureStrings.Display_Email));

            RuleFor(obj => obj)
                .EmailAddress()
                .WithMessage(obj => string.Format(InfrastructureStrings.Property_InvalidFormat, obj, InfrastructureStrings.Display_Email.ToLower()))
                .When(obj => !string.IsNullOrWhiteSpace(obj));
        }
    }
}
