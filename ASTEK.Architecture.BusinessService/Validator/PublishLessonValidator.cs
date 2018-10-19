using ASTEK.Architecture.BusinessService.Rule;
using ASTEK.Architecture.Domain.Entity.Lesson;
using ASTEK.Architecture.Infrastructure.Validator.Abstract;
using ASTEK.Architecture.Repository.Concrete;
using System;

namespace ASTEK.Architecture.BusinessService.Validator
{
    public class PublishLessonValidator: ValidatorBusinessBase
    {
        private readonly Lesson Lesson;
        
        public PublishLessonValidator(Lesson lesson)
        {
            Lesson = lesson;
        }

        public override void AddRules()
        {
            AddRule(new ChapterCountRule(Lesson.LessonChapters.Count));
        }
    }
}
