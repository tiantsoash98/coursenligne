using ASTEK.Architecture.Infrastructure.Validator.Abstract;
using ASTEK.Architecture.Repository.Concrete;

namespace ASTEK.Architecture.BusinessService.Validator
{
    public class CreateLessonPartValidator : ValidatorBusinessBase
    {
        private readonly EFLessonPartRepository _LessonPartRepository;
        private readonly Domain.Entity.LessonPart.LessonPart LessonPart;

        public CreateLessonPartValidator(EFLessonPartRepository lessonPartRepository, Domain.Entity.LessonPart.LessonPart lessonPart)
        {
            _LessonPartRepository = lessonPartRepository;
            LessonPart = lessonPart;
        }

        public override void AddRules()
        {
        }
    }
}
