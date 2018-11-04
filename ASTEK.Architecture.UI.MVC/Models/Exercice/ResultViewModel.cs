using ASTEK.Architecture.ApplicationService.Entity.AnswerExercice;

namespace ASTEK.Architecture.UI.MVC.Models.Exercice
{
    public class ResultViewModel: BaseViewModel
    {
        public Domain.Entity.AnswerExercice.AnswerExercice AnswerExercice { get; set; }
        public CorrectAnswerInputModel Input { get; set; }
        public string FullPath { get; set; }
    }
}