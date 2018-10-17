using ASTEK.Architecture.ApplicationService.Entity.Lesson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASTEK.Architecture.UI.MVC.Models.Lesson
{
    public class LessonAddDetailsViewModels: BaseViewModel
    {
        public string LessonId { get; set; }
        public string Source { get; set; }
    }
}