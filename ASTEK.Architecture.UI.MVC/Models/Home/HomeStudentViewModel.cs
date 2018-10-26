using System.Collections.Generic;

namespace ASTEK.Architecture.UI.MVC.Models.Home
{
    public class HomeStudentViewModel: BaseViewModel
    {
        public List<Domain.Entity.Lesson.Lesson> MayLike { get; set; }
        public List<Domain.Entity.LessonFollowed.LessonFollowed> LessonsFollowed { get; set; }
        public List<Domain.Entity.Lesson.Lesson> Recents { get; set; }
        public int TotalRecentsPage { get; set; }
        public int RecentPage { get; set; }
    }
}