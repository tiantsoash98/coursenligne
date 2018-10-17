using FluentValidation;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASTEK.Architecture.Infrastructure.Validator.Concrete
{
    public class BirthdayValidator : AbstractValidator<DateTime>
    {
        public BirthdayValidator()
        {
            RuleFor(obj => obj)
                .Must(ValidateMinAge)
                .WithMessage(x => string.Format(InfrastructureStrings.Age_Minimum, ConfigurationManager.AppSettings.Get("minAgeStudent")));
        }

        public bool ValidateMinAge(DateTime date)
        {
            var minAge = Convert.ToInt32(ConfigurationManager.AppSettings.Get("minAgeStudent"));
            int age = DateTime.Now.Year - date.Year;

            return age >= minAge;
        }
    }
}
