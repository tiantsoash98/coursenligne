using ASTEK.Architecture.BusinessService.Entity.AnswerExercice;
using ASTEK.Architecture.BusinessService.Interface;
using ASTEK.Architecture.Infrastructure.Utility;

namespace ASTEK.Architecture.ApplicationService.Entity.AnswerExercice
{
    public class AnswerExerciceAppService
    {
        private readonly IAnswerExerciceBusinessService _service;

        public AnswerExerciceAppService()
        {
            _service = new AnswerExerciceBusinessService();
        }

        public UploadAnswerOutputModel Upload(UploadAnswerInputModel input)
        {
            var request = new UploadAnswerRequest
            {
                AccountId = GuidUtilities.TryParse(input.AccountId),
                LessonId = GuidUtilities.TryParse(input.LessonId),
                FileName = input.FileName,
                Comment = input.Comment
            };

            UploadAnswerResponse response = _service.Upload(request);

            return new UploadAnswerOutputModel { Response = response };
        }
    }
}
