using ASTEK.Architecture.ApplicationService.Entity.AnswerExercice;

namespace ASTEK.Architecture.UI.MVC.Models.Dashboard
{
    public class UnmarkedAnswerViewModel
    {
        public GetAnswerExerciceOutputModel AnswerOutput { get; set; }
        public bool IsTeacher { get; set; }
    }
}