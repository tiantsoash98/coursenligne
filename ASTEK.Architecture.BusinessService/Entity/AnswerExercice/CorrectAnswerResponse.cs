using ASTEK.Architecture.Infrastructure.DTO;

namespace ASTEK.Architecture.BusinessService.Entity.AnswerExercice
{
    public class CorrectAnswerResponse: Response
    {
        public Domain.Entity.AnswerExercice.AnswerExercice Corrected { get; set; }
    }
}
