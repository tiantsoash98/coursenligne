using ASTEK.Architecture.BusinessService.Entity.AnswerExercice;

namespace ASTEK.Architecture.BusinessService.Interface
{
    public interface IAnswerExerciceBusinessService
    {
        UploadAnswerResponse Upload(UploadAnswerRequest request);
        CorrectAnswerResponse Correct(CorrectAnswerRequest request);
    }
}
