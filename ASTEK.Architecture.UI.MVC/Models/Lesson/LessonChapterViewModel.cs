using ASTEK.Architecture.ApplicationService.Entity.Lesson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASTEK.Architecture.UI.MVC.Models.Lesson
{
    public class LessonChapterViewModel: BaseLessonViewModel
    {     
        public Domain.Entity.LessonChapter.LessonChapter Chapter { get; set; }    
        public int CountParts { get; set; }
    }
}