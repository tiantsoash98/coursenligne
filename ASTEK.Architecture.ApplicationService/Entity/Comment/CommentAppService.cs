using ASTEK.Architecture.BusinessService.Entity.Comment;
using ASTEK.Architecture.BusinessService.Interface;
using ASTEK.Architecture.Infrastructure.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASTEK.Architecture.ApplicationService.Entity.Comment
{
    public class CommentAppService
    {
        private readonly ICommentBusinessService _service;

        public CommentAppService()
        {
            _service = new CommentBusinessService();
        }

        public AddCommentOutputModel Add(AddCommentInputModel input)
        {
            var request = new AddCommentRequest
            {
                AccountId = GuidUtilities.TryParse(input.AccountId),
                LessonId = GuidUtilities.TryParse(input.LessonId),
                Content = input.Content
            };

            AddCommentResponse response = _service.Add(request);

            return new AddCommentOutputModel
            {
                Response = response
            };
        }

        public GetAllCommentOutputModel GetAll(GetAllCommentInputModel input)
        {
            var request = new GetAllCommentRequest
            {
                LessonId = GuidUtilities.TryParse(input.LessonId),
                Count = input.Count,
                LoadAnswers = input.LoadAnswers
            };

            GetAllCommentResponse response = _service.GetAll(request);

            return new GetAllCommentOutputModel
            {
                Response = response
            };
        }
    }
}
