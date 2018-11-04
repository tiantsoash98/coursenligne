using ASTEK.Architecture.ApplicationService.Entity.Lesson;
using System.Web.Mvc;

namespace ASTEK.Architecture.UI.MVC.Models.Lesson
{
    public class LessonAddViewModel: BaseViewModel
    {
        public CreateLessonInputModel Input { get; set; }
        public SelectList LevelList { get; set; }
    }
}