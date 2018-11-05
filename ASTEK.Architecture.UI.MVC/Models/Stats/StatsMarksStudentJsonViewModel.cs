using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASTEK.Architecture.UI.MVC.Models.Stats
{
    public class StatsMarksStudentJsonViewModel
    {
        public List<StatsMarkStudent> Marks { get; set; }
    }

    public class StatsMarkStudent
    {
        public string LessonTitle { get; set; }
        public decimal Mark { get; set; }
    }
}