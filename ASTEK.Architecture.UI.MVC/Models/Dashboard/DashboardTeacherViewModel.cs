using ASTEK.Architecture.ApplicationService.Entity.Lesson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASTEK.Architecture.UI.MVC.Models.Dashboard
{
    public class DashboardTeacherViewModel: DashboardViewModel
    {
        public int UnpublishedPage { get; set; }
        public GetLessonByStateOutputModel PostedOutput { get; set; }      
        public GetLessonByStateOutputModel UnpublishedOutput { get; set; }
        public int PostedCount { get; set; }
        public int TotalViewCount { get; set; }
    }
}