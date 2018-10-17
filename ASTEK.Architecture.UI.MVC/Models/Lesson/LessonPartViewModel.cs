using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASTEK.Architecture.UI.MVC.Models.Lesson
{
    public class LessonPartViewModel: BaseLessonViewModel
    {
        public Domain.Entity.LessonPart.LessonPart Part { get; set; }
    }
}