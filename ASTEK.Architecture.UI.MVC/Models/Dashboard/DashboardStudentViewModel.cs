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
        public GetFollowedByOutputModel FollowedOutput { get; set; }
        public GetAllSubscribedOutputModel SubscribedOutput { get; set; }
        public int FollowedCount { get; set; }
    }
}