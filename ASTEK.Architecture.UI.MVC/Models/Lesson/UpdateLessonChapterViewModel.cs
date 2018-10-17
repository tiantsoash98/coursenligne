using ASTEK.Architecture.ApplicationService.Entity.LessonChapter;
using ASTEK.Architecture.ApplicationService.Entity.LessonPart;
using ASTEK.Architecture.Infrastructure.Navigation;
using System.Collections.Generic;

namespace ASTEK.Architecture.UI.MVC.Models.Lesson
{
    public class UpdateLessonChapterViewModel : BaseViewModel
    {
        public string LessonId { get; set; }
        public short ChapterNumber { get; set; }
        public UpdateLessonChapterInputModel ChapterInput { get; set; }
        public List<UpdateLessonPartInputModel> PartsInput { get; set; }
        public LessonNavigation Navigation { get; set; }
        public string Status { get; set; }
    }
}