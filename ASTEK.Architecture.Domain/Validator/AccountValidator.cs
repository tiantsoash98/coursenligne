using ASTEK.Architecture.Domain.Entity.Account;
using ASTEK.Architecture.Infrastructure.Domain;
using ASTEK.Architecture.Infrastructure.Validator.Concrete;
using FluentValidation;
using System;

namespace ASTEK.Architecture.Domain.Validator
{
    public class AccountValidator: ValidatorDomainBase<Account, Guid>
    {
        public AccountValidator(ValidationType validationType): base(validationType)
        {                         
            if (validationType == ValidationType.Add)
            {
                RuleFor(obj => obj.ACCEMAIL)
                    .SetValidator(new MailValidator());

                RuleFor(obj => obj.ACCPASSWORD)
                    .SetValidator(new PasswordValidator());           

                RuleFor(obj => obj.ACCPHONECONTACT)
                    .SetValidator(new PhoneNumberValidator())
                    .When(obj => !string.IsNullOrWhiteSpace(obj.ACCPHONECONTACT));
            }
            if (validationType == ValidationType.Update)
            {
                RuleFor(obj => obj.ACCPHONECONTACT)
                    .SetValidator(new PhoneNumberValidator())
                    .When(obj => !string.IsNullOrWhiteSpace(obj.ACCPHONECONTACT));
            }
            else if(validationType == ValidationType.Get)
            {
                RuleFor(obj => obj.ACCEMAIL)
                    .SetValidator(new MailValidator());
            }
        }
    }
}
