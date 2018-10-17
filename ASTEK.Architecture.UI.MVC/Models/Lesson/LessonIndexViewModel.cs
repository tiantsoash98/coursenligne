using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASTEK.Architecture.UI.MVC.Models.Lesson
{
    public class LessonIndexViewModel: BaseLessonViewModel
    {
        public string[] Targets { get; set; }
        public int ExerciceCount { get; set; }
        public int ChapterCount { get; set; }
        public int FollowCount { get; set; }
    }
}