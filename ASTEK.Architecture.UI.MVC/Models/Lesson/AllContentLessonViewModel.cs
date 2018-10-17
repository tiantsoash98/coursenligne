using ASTEK.Architecture.Infrastructure.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASTEK.Architecture.UI.MVC.Models.Lesson
{
    public class AllContentLessonViewModel
    {
        public Domain.Entity.Lesson.Lesson Lesson { get; set; }
        public string[] Targets { get; set; }
    }
}