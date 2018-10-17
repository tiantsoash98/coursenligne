using ASTEK.Architecture.Domain.Entity.AccountStudent;
using ASTEK.Architecture.Infrastructure.Domain;
using ASTEK.Architecture.Infrastructure.Validator.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASTEK.Architecture.Domain.Validator
{
    public class AccountStudentValidator : ValidatorDomainBase<AccountStudent, Guid>
    {
        public AccountStudentValidator(ValidationType validationType) : base(validationType)
        {
            if (validationType == ValidationType.Add || validationType == ValidationType.Update)
            {
                RuleFor(obj => obj.ACSFIRSTNAME)
                    .SetValidator(new NameValidator(DomainStrings.Display_FirstName));

                RuleFor(obj => obj.ACSNAME)
                    .SetValidator(new NameValidator(DomainStrings.Display_Name));

                RuleFor(obj => obj.ACSBIRTHDAY)
                    .SetValidator(new BirthdayValidator());
            }
        }
    }
}
