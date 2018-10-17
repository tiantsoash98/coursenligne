using ASTEK.Architecture.Infrastructure.Validator.Abstract;
using ASTEK.Architecture.Repository.Concrete;

namespace ASTEK.Architecture.BusinessService.Validator
{
    public class CreateLessonValidator : ValidatorBusinessBase
    {
        private readonly EFLessonRepository _lessonRepository;
        private readonly Domain.Entity.Lesson.Lesson Lesson;

        public CreateLessonValidator(EFLessonRepository lessonRepository, Domain.Entity.Lesson.Lesson lesson)
        {
            _lessonRepository = lessonRepository;
            Lesson = lesson;
        }

        public override void AddRules()
        {
        }
    }
}
