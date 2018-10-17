using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASTEK.Architecture.Infrastructure.Validator.Concrete
{
    public class DurationValidator : AbstractValidator<long?>
    {
        public DurationValidator()
        {
            RuleFor(obj => obj)
                .GreaterThanOrEqualTo(0)
                    .WithMessage(x => string.Format(InfrastructureStrings.Property_MustBeGreaterThanZero, InfrastructureStrings.Display_Duration));
        }
    }
}
