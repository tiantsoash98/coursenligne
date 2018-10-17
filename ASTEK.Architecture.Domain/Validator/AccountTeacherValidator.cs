using ASTEK.Architecture.Domain.Entity.AccountTeacher;
using ASTEK.Architecture.Infrastructure.Domain;
using ASTEK.Architecture.Infrastructure.Validator.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASTEK.Architecture.Domain.Validator
{
    public class AccountTeacherValidator: ValidatorDomainBase<AccountTeacher, Guid>
    {
        public AccountTeacherValidator(ValidationType validationType) : base(validationType)
        {
            if(validationType == ValidationType.Add || validationType == ValidationType.Update)
            {
                RuleFor(obj => obj.ACTFIRSTNAME)
                    .SetValidator(new NameValidator(DomainStrings.Display_FirstName));

                RuleFor(obj => obj.ACTNAME)
                    .SetValidator(new NameValidator(DomainStrings.Display_Name));

                RuleFor(obj => obj.ACTBIRTHDAY)
                    .SetValidator(new BirthdayValidator());

                RuleFor(obj => obj.ACTTOWN)
                    .SetValidator(new TownValidator());

                RuleFor(obj => obj.ACTPOSTALCODE)
                    .SetValidator(new PostalCodeValidator());

                RuleFor(obj => obj.ACTADDRESS)
                    .SetValidator(new AddressValidator());
            }
        }
    }
}
