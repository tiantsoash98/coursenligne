using ASTEK.Architecture.ApplicationService.Entity.LessonChapter;
using ASTEK.Architecture.ApplicationService.Entity.LessonPart;
using ASTEK.Architecture.Infrastructure.Navigation;
using System.Collections.Generic;

namespace ASTEK.Architecture.UI.MVC.Models.Lesson
{
    public class LessonAddChapterViewModel: BaseViewModel
    {
        public string LessonId { get; set; }
        public int ChapterNumber { get; set; }
        public string Type { get; set; }
        public LessonNavigation Navigation { get; set; }
        public CreateLessonChapterInputModel ChapterInput { get; set; }
        public List<CreateLessonPartInputModel> PartsInput { get; set; }
    }
}