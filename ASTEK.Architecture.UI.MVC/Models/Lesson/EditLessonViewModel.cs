using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASTEK.Architecture.UI.MVC.Models.Lesson
{
    public class EditLessonViewModel
    {
        public string LessonId { get; set; }
        public bool Editable { get; set; }
        public bool Deletable { get; set; }
        public bool HasImage { get; set; }
        public bool HasChapter { get; set; }
    }
}