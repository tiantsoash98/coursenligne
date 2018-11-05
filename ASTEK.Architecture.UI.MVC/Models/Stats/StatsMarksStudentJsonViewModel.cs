using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASTEK.Architecture.UI.MVC.Models.Stats
{
    public class StatsMarksStudentJsonViewModel
    {
        public List<string> labels { get; set; }
        public List<DataSets> datasets { get; set; }
        //public List<StatsMarkStudent> Marks { get; set; }
    }

    public class StatsMarkStudent
    {
        public string LessonTitle { get; set; }
        public decimal Mark { get; set; }
    }

    public class DataSets
    {
        public List<decimal> data { get; set; }
        public string label { get; set; }
        public string borderColor { get; set; }
        public bool fill { get; set; }
    }
}