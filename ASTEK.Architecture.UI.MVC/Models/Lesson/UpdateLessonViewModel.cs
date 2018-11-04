using ASTEK.Architecture.ApplicationService.Entity.Lesson;
using System.Web.Mvc;

namespace ASTEK.Architecture.UI.MVC.Models.Lesson
{
    public class UpdateLessonViewModel: BaseViewModel
    {
        public UpdateLessonInputModel Input { get; set; }
        public string Status { get; set; }
        public SelectList LevelList { get; set; }
    }
}