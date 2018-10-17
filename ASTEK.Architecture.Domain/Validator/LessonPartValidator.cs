using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ASTEK.Architecture.Domain.Entity.LessonPart;
using ASTEK.Architecture.Infrastructure.Domain;
using ASTEK.Architecture.Infrastructure.Validator.Concrete;

namespace ASTEK.Architecture.Domain.Validator
{
    public class LessonPartValidator : ValidatorDomainBase<LessonPart, Guid>
    {
        public LessonPartValidator(ValidationType validationType) : base(validationType)
        {
            if(validationType == ValidationType.Add)
            {
                RuleFor(obj => obj.LSPTITLE)
                    .SetValidator(new TitleValidator());

                RuleFor(obj => obj.LSPCONTENT)
                    .SetValidator(new ContentValidator());
            }
        }
    }
}
