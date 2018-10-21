using ASTEK.Architecture.BusinessService.Entity.CommentAnswer;
using ASTEK.Architecture.BusinessService.Interface;
using ASTEK.Architecture.Infrastructure.Utility;

namespace ASTEK.Architecture.ApplicationService.Entity.CommentAnswer
{
    public class CommentAnswerAppService
    {
        private readonly ICommentAnswerBusinessService _service;

        public CommentAnswerAppService()
        {
            _service = new CommentAnswerBusinessService();
        }

        public AddCommentAnswerOutputModel Add(AddCommentAnswerInputModel input)
        {
            var request = new AddCommentAnswerRequest
            {
                AccountId = GuidUtilities.TryParse(input.AccountId),
                CommentId = GuidUtilities.TryParse(input.CommentId),
                Content = input.Content
            };

            AddCommentAnswerResponse response = _service.Add(request);

            return new AddCommentAnswerOutputModel
            {
                Response = response
            };
        }

        public GetAllCommentAnswerOutputModel GetAll(GetAllCommentAnswerInputModel input)
        {
            var request = new GetAllCommentAnswerRequest
            {
                CommentId = GuidUtilities.TryParse(input.CommentId),
                Count = input.Count
            };

            GetAllCommentAnswerResponse response = _service.GetAll(request);

            return new GetAllCommentAnswerOutputModel
            {
                Response = response
            };
        }
    }
}
