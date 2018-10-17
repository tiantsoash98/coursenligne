using ASTEK.Architecture.BusinessService.Entity.LessonFollowed;
using ASTEK.Architecture.BusinessService.Interface;
using ASTEK.Architecture.Infrastructure.Utility;

namespace ASTEK.Architecture.ApplicationService.Entity.LessonFollowed
{
    public class LessonFollowedAppService
    {
        private readonly ILessonFollowedBusinessService _service;

        public LessonFollowedAppService()
        {
            _service = new LessonFollowedBusinessService();
        }

        public FinishLessonOutputModel FinishLesson(FinishLessonInputModel input)
        {
            var request = new FinishLessonRequest
            {
                AccountId = GuidUtilities.TryParse(input.AccountId),
                LessonId = GuidUtilities.TryParse(input.LessonId),
                ChapterNumber = input.ChapterNumber,
                PartNumber = input.PartNumber
            };

            FinishLessonResponse response = _service.FinishLesson(request);

            return new FinishLessonOutputModel
            {
                Response = response
            };
        }

        public FinishPartOutputModel FinishPart(FinishPartInputModel input)
        {
            var request = new FinishPartRequest
            {
                AccountId = GuidUtilities.TryParse(input.AccountId),
                LessonId = GuidUtilities.TryParse(input.LessonId),
                ChapterNumber = input.ChapterNumber,
                PartNumber = input.PartNumber
            };

            FinishPartResponse response = _service.FinishPart(request);

            return new FinishPartOutputModel
            {
                Response = response
            };
        }

        public FollowLessonOutputModel Follow(FollowLessonInputModel input)
        {
            var request = new FollowLessonRequest
            {
                AccountId = GuidUtilities.TryParse(input.AccountId),
                LessonId = GuidUtilities.TryParse(input.LessonId)
            };

            FollowLessonResponse response = _service.Follow(request);

            return new FollowLessonOutputModel
            {
                Response = response
            };
        }

        public CountByLessonOutputModel CountByLesson(CountByLessonInputModel input)
        {
            var request = new CountByLessonRequest
            {
                LessonId = GuidUtilities.TryParse(input.LessonId),
                FromDate = input.FromDate,
                ToDate = input.ToDate
            };

            CountByLessonResponse response = _service.CountByLesson(request);

            var output = new CountByLessonOutputModel
            {
                Response = response
            };

            return output;
        }

        public CountByAccountOutputModel CountByAccount(CountByAccountInputModel input)
        {
            var request = new CountByAccountRequest
            {
                AccountId = GuidUtilities.TryParse(input.AccountId),
                FromDate = input.FromDate,
                ToDate = input.ToDate
            };

            CountByAccountResponse response = _service.CountByAccount(request);

            var output = new CountByAccountOutputModel
            {
                Response = response
            };

            return output;
        }

        public GetFollowedByOutputModel GetFollowedBy(GetFollowedByInputModel input)
        {
            var request = new GetFollowedByRequest
            {
                AccountId = GuidUtilities.TryParse(input.AccountId),
                Page = input.Page,
                Count = input.Count           
            };

            GetFollowedByResponse response = _service.GetFollowedBy(request);

            var output = new GetFollowedByOutputModel
            {
                Response = response
            };

            return output;
        }

        public CountTotalViewsOfAccountOutputModel CountTotalViewsOfAccount(CountTotalViewsOfAccountInputModel input)
        {
            var request = new CountTotalViewsOfAccountRequest
            {
                AccountId = GuidUtilities.TryParse(input.AccountId),
                FromDate = input.FromDate,
                ToDate = input.ToDate
            };

            CountTotalViewsOfAccountResponse response = _service.CountTotalViewsOfAccount(request);

            return new CountTotalViewsOfAccountOutputModel
            {
                Response = response
            };
        }

        public GetByLessonOutputModel GetByLesson(GetByLessonInputModel input)
        {
            var request = new GetByLessonRequest
            {
                LessonId = GuidUtilities.TryParse(input.LessonId)
            };

            GetByLessonResponse response = _service.GetByLesson(request);

            return new GetByLessonOutputModel
            {
                Response = response
            };
        }
    }
}
