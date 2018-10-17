using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ASTEK.Architecture.Infrastructure.Domain;
using ASTEK.Architecture.Domain.Entity.LessonChapter;
using ASTEK.Architecture.Infrastructure.Validator.Concrete;
using FluentValidation;

namespace ASTEK.Architecture.Domain.Validator
{
    public class LessonChapterValidator : ValidatorDomainBase<LessonChapter, Guid>
    {
        public LessonChapterValidator(ValidationType validationType) : base(validationType)
        {
            if(validationType == ValidationType.Add)
            {
                RuleFor(obj => obj.LSCTITLE)
                    .SetValidator(new TitleValidator());

                RuleFor(obj => obj.LSCDESCRIPTION)
                    .SetValidator(new DescriptionValidator());

                RuleFor(obj => obj.LSCCONTENT)
                    .SetValidator(new ContentValidator());

                RuleFor(obj => obj.LSCDURATION)
                    .SetValidator(new DurationValidator())
                    .When(obj => obj.LSCDURATION.HasValue);
            }
        }
    }
}
