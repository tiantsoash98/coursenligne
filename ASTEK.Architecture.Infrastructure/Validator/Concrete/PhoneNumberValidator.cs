using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ASTEK.Architecture.Infrastructure.Validator.Concrete
{
    // Web Site: https://numverify.com/dashboard
    // API for phone number validation: http://apilayer.net/api/validate?access_key=KEY_ACESS&number=PHONE_NUMBER&country_code=COUNTRY_CODE&format=1
    public class PhoneNumberValidator: AbstractValidator<string>
    {
        //Can only contain :
        //-alphanumerics
        //-hyphens
        public const string RegexPattern = "[\\d\\s+]";

        public PhoneNumberValidator()
        {
            RuleFor(obj => obj)
                .NotEmpty()
                .WithMessage(x => string.Format(InfrastructureStrings.Property_IsNotNullOrWhiteSpace, InfrastructureStrings.Display_PhoneNumber));

            RuleFor(obj => obj)
                .Must(PhoneNumberFormat)
                .WithMessage(obj => string.Format(InfrastructureStrings.Property_InvalidFormat, obj, InfrastructureStrings.Display_PhoneNumber.ToLower()));
        }

        private bool PhoneNumberFormat(string phoneNumber)
        {
            return Regex.IsMatch(phoneNumber, RegexPattern);
        }
    }
}
