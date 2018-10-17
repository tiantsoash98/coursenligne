using ASTEK.Architecture.ApplicationService.Entity.Lesson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASTEK.Architecture.UI.MVC.Models.Lesson
{
    public class BaseLessonViewModel: BaseViewModel
    {
        public Domain.Entity.Lesson.Lesson Lesson { get; set; }
        public LessonNavigationViewModel Navigation { get; set; }
        public GetLessonNextStepOutputModel NextStep { get; set; }
        public List<BreadCrumbViewModel> BreadCrumbs { get; set; }   
    }
}