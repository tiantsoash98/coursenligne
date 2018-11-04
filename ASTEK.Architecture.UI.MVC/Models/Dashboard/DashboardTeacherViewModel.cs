using ASTEK.Architecture.ApplicationService.Entity.AnswerExercice;
using ASTEK.Architecture.ApplicationService.Entity.Lesson;
using ASTEK.Architecture.ApplicationService.Entity.SubscribeActivity;

namespace ASTEK.Architecture.UI.MVC.Models.Dashboard
{
    public class DashboardTeacherViewModel: DashboardViewModel
    {
        public int UnpublishedPage { get; set; }
        public GetLessonByStateOutputModel PostedOutput { get; set; }      
        public GetLessonByStateOutputModel UnpublishedOutput { get; set; }
        public GetAllSubscribersOutputModel SubscribersOutput { get; set; }
        public int PostedCount { get; set; }
        public int TotalViewCount { get; set; }
        public int SubscribersCount { get; set; }
        public GetAllOutputModel GetAllUnmarkedOutput { get; set; }
        public int TotalUnmarked { get; set; }
        public GetAllOutputModel GetAllMarkedOutput { get; set; }
        public int TotalMarked { get; set; }
        public int UnmarkedCount { get; set; }
    }
}