using System.Collections.Generic;

namespace ASTEK.Architecture.UI.MVC.Models.Home
{
    public class HomeStudentViewModel: BaseViewModel
    {
        public List<Domain.Entity.Lesson.Lesson> MayLike { get; set; }
        public List<Domain.Entity.LessonFollowed.LessonFollowed> LessonsFollowed { get; set; }
    }
}