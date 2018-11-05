using ASTEK.Architecture.BusinessService.Entity.AnswerExercice;

namespace ASTEK.Architecture.BusinessService.Interface
{
    public interface IAnswerExerciceBusinessService
    {
        GetAnswerExerciceResponse Get(GetAnswerExerciceRequest request);
        UploadAnswerResponse Upload(UploadAnswerRequest request);
        CorrectAnswerResponse Correct(CorrectAnswerRequest request);
        GetAllResponse GetAll(GetAllRequest request);
        HasPostedResponse HasPosted(HasPostedRequest request);
        CountAnswerResponse Count(CountAnswerRequest request);
        GetMarksOfStudentResponse GetMarksOfStudent(GetMarksOfStudentRequest request);
    }
}
