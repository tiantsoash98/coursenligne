using ASTEK.Architecture.Infrastructure.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASTEK.Architecture.UI.MVC.Models.Lesson
{
    public class LessonNavigationViewModel
    {
        public LessonNavigation Navigation { get; set; }
        public string LessonId { get; set; }
        public short CurrentChapter { get; set; }
        public short CurrentPart { get; set; }
        public bool HasExercice { get; set; }
        public bool HasDocument { get; set; }
        public bool HasVideo { get; set; }
        public bool HasAudio { get; set; }
        public bool HasCorrection { get; set; }
    }
}