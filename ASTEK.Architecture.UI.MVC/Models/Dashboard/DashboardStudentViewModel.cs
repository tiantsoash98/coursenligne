using ASTEK.Architecture.ApplicationService.Entity.AnswerExercice;
using ASTEK.Architecture.ApplicationService.Entity.LessonFollowed;
using ASTEK.Architecture.ApplicationService.Entity.SubscribeActivity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASTEK.Architecture.UI.MVC.Models.Dashboard
{
    public class DashboardStudentViewModel: DashboardViewModel
    {      
        public string AccountId { get; set; }
        public GetFollowedByOutputModel FollowedOutput { get; set; }
        public GetAllSubscribedOutputModel SubscribedOutput { get; set; }
        public int FollowedCount { get; set; }
        public GetAllOutputModel GetAllUnmarkedOutput { get; set; }
        public int TotalUnmarked { get; set; }
        public GetAllOutputModel GetAllMarkedOutput { get; set; }
        public int TotalMarked { get; set; }
        public int UnmarkedCount { get; set; }
    }
}