using ASTEK.Architecture.Infrastructure.Validator.Abstract;
using ASTEK.Architecture.Repository.Concrete;

namespace ASTEK.Architecture.BusinessService.Validator
{
    public class CreateLessonChapterValidator : ValidatorBusinessBase
    {
        private readonly EFLessonChapterRepository _LessonChapterRepository;
        private readonly Domain.Entity.LessonChapter.LessonChapter LessonChapter;

        public CreateLessonChapterValidator(EFLessonChapterRepository lessonChapterRepository, Domain.Entity.LessonChapter.LessonChapter lessonChapter)
        {
            _LessonChapterRepository = lessonChapterRepository;
            LessonChapter = lessonChapter;
        }

        public override void AddRules()
        {
        }
    }
}
