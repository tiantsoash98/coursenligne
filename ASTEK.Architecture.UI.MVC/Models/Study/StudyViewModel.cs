using System.Collections.Generic;

namespace ASTEK.Architecture.UI.MVC.Models.Study
{
    public class StudyViewModel: BaseViewModel
    {
        public string Id { get; set; }
        public int Page { get; set; }
        public Domain.Entity.Study.Study Study { get; set; }
        public List<Domain.Entity.Lesson.Lesson> BestLessons { get; set; }
    }
}