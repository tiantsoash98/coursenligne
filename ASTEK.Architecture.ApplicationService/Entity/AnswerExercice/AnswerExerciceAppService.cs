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

        public CorrectAnswerOutputModel Correct(CorrectAnswerInputModel input)
        {
            var request = new CorrectAnswerRequest
            {
                AnswerId = GuidUtilities.TryParse(input.AnswerId),
                Comment = input.Comment,
                Mark = input.Mark,
                Valuation = input.Valuation
            };

            CorrectAnswerResponse response = _service.Correct(request);

            return new CorrectAnswerOutputModel { Response = response };
        }

        public GetAnswerExerciceOutputModel Get(GetAnswerExerciceInputModel input)
        {
            var request = new GetAnswerExerciceRequest
            {
                AnswerId = GuidUtilities.TryParse(input.AnswerId)
            };

            GetAnswerExerciceResponse response = _service.Get(request);

            return new GetAnswerExerciceOutputModel { Response = response };
        }

        public HasPostedOutputModel HasPosted(HasPostedInputModel input)
        {
            var request = new HasPostedRequest
            {
                AccountId = GuidUtilities.TryParse(input.AccountId),
                LessonId = GuidUtilities.TryParse(input.LessonId)
            };

            HasPostedResponse response = _service.HasPosted(request);

            return new HasPostedOutputModel { Response = response };
        }

        public GetAllOutputModel GetAll(GetAllInputModel input)
        {
            var request = new GetAllRequest
            {
                AccountId = GuidUtilities.TryParse(input.AccountId),
                Page = input.Page,
                Count = input.Count,
                Type = input.Type,
                Marked = input.Marked
            };

            if (!string.IsNullOrEmpty(input.LessonId))
            {
                request.LessonId = GuidUtilities.TryParse(input.LessonId);
            }

            GetAllResponse response = _service.GetAll(request);

            return new GetAllOutputModel { Response = response };
        }
    }
}
