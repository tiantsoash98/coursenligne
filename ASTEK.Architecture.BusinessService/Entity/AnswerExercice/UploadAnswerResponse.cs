using ASTEK.Architecture.Infrastructure.DTO;

namespace ASTEK.Architecture.BusinessService.Entity.AnswerExercice
{
    public class UploadAnswerResponse: Response
    {
        public Domain.Entity.AnswerExercice.AnswerExercice AnswerExercice { get; set; }
    }
}
