using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ASTEK.Architecture.Infrastructure.Domain;
using ASTEK.Architecture.Domain.Entity.Lesson;
using FluentValidation;
using ASTEK.Architecture.Infrastructure.Validator.Concrete;

namespace ASTEK.Architecture.Domain.Validator
{
    public class LessonValidator : ValidatorDomainBase<Lesson, Guid>
    {
        public LessonValidator(ValidationType validationType) : base(validationType)
        {
            if(validationType == ValidationType.Add || validationType == ValidationType.Update)
            {
                RuleFor(obj => obj.LSNTITLE)
                    .SetValidator(new TitleValidator());

                RuleFor(obj => obj.LSNDESCRIPTION)
                    .SetValidator(new DescriptionValidator());

                RuleFor(obj => obj.LSNTARGET)
                    .SetValidator(new DescriptionValidator());

                RuleFor(obj => obj.LSNDURATION)
                    .SetValidator(new DurationValidator())
                    .When(obj => obj.LSNDURATION.HasValue);               
            }
        }
    }
}
