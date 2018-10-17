using ASTEK.Architecture.Infrastructure.Navigation;
using System.Collections.Generic;

namespace ASTEK.Architecture.UI.MVC.Models.Dashboard
{
    public class StudentsProgressionViewModel
    {
        public string LessonId { get; set; }
        public LessonNavigation Navigation { get; set; }
        public List<FollowerProgressionViewModel> Followers { get; set; }
    }
}