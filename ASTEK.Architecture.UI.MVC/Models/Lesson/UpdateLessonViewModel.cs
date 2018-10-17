using ASTEK.Architecture.ApplicationService.Entity.Lesson;

namespace ASTEK.Architecture.UI.MVC.Models.Lesson
{
    public class UpdateLessonViewModel: BaseViewModel
    {
        public UpdateLessonInputModel Input { get; set; }
        public string Status { get; set; }
    }
}