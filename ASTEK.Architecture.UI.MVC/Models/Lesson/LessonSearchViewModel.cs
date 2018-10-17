using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASTEK.Architecture.UI.MVC.Models.Lesson
{
    public class LessonSearchViewModel: BaseViewModel
    {
        public string Query { get; set; }
        public int Page { get; set; }
        public int TotalPages { get; set; }
        public List<Domain.Entity.Lesson.Lesson> Lessons { get; set; }
    }
}