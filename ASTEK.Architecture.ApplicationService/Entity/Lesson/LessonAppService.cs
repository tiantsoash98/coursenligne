using ASTEK.Architecture.BusinessService.Entity.Lesson;
using ASTEK.Architecture.BusinessService.Interface;
using ASTEK.Architecture.Infrastructure.Utility;
using System;
using System.Threading.Tasks;

namespace ASTEK.Architecture.ApplicationService.Entity.Lesson
{
    public class LessonAppService
    {
        private readonly ILessonBusinessService _service;

        public LessonAppService()
        {
            _service = new LessonBusinessService();
        }

        public CountLessonPostedByOutputModel CountPostedBy(CountLessonPostedByInputModel input)
        {
            var request = new CountLessonPostedByRequest
            {
                AccountId = GuidUtilities.TryParse(input.AccountId),
                FromDate = input.FromDate,
                ToDate = input.ToDate
            };

            CountLessonPostedByResponse response = _service.CountPostedBy(request);

            var output = new CountLessonPostedByOutputModel
            {
                Response = response
            };

            return output;
        }

        public CreateLessonOutputModel Create(CreateLessonInputModel input)
        {
            var request = new CreateLessonRequest
            {
                AccountId = input.AccountId,
                Title = input.Title,
                Study = GuidUtilities.TryParse(input.Study),
                Description = input.Description,
                Target = input.Targets,
                Confidentiality = new Guid(input.Confidentiality)
            };

            CreateLessonResponse response = _service.Create(request);

            var output = new CreateLessonOutputModel
            {
                Response = response
            };

            return output;
        }

        public GetLessonOutputModel Get(GetLessonInputModel input)
        {
            var request = new GetLessonRequest
            {
                LessonId = GuidUtilities.TryParse(input.Id),
                GetAlternativePicture = input.GetAlternativePicture
            };

            GetLessonResponse response = _service.Get(request);

            return new GetLessonOutputModel { Response = response };
        }

        public GetBestLessonByStudyOutputModel GetBestByStudy(GetBestLessonByStudyInputModel input)
        {
            var request = new GetBestLessonByStudyRequest
            {
                StudyCode = GuidUtilities.TryParse(input.StudyCode),
                Page = input.Page,
                Count = input.Count,
                GetAlternativePicture = input.GetAlternativePicture,
                GetThumbnailPicture = input.GetThumbnailPicture
            };

            GetBestLessonByStudyResponse response = _service.GetBestByStudy(request);

            return new GetBestLessonByStudyOutputModel { Response = response };
        }

        public GetLessonMayLikeOutputModel GetMayLike(GetLessonMayLikeInputModel input)
        {
            var request = new GetLessonMayLikeRequest
            {
                Page = input.Page,
                Count = input.Count,
                GetAlternativePicture = input.GetAlternativePicture,
                GetThumbnailPicture = input.GetThumbnailPicture
            };

            GetLessonMayLikeResponse response = _service.GetMayLike(request);

            return new GetLessonMayLikeOutputModel { Response = response };
        }

        public GetLessonChapterCountOutputModel GetChapterCount(GetLessonChapterCountInputModel input)
        {
            var request = new GetLessonChapterCountRequest
            {
                LessonId = GuidUtilities.TryParse(input.LessonId)
            };

            GetLessonChapterCountResponse response = _service.GetChapterCount(request);

            return new GetLessonChapterCountOutputModel { Response = response };
        }

        public GetLessonExerciceCountOutputModel GetExerciceCount(GetLessonExerciceCountInputModel input)
        {
            var request = new GetLessonExerciceCountRequest
            {
                LessonId = GuidUtilities.TryParse(input.LessonId)
            };

            GetLessonExerciceCountResponse response = _service.GetExerciceCount(request);

            return new GetLessonExerciceCountOutputModel { Response = response };
        }

        public GetLessonNavigationOutputModel GetNavigation(GetLessonNavigationInputModel input)
        {
            var request = new GetLessonNavigationRequest
            {
                LessonId = GuidUtilities.TryParse(input.LessonId)
            };

            GetLessonNavigationResponse response = _service.GetNavigation(request);

            return new GetLessonNavigationOutputModel { Response = response };
        }

        public GetLessonNextStepOutputModel GetNextStep(GetLessonNextStepInputModel input)
        {
            var request = new GetLessonNextStepRequest
            {
                Navigation = input.Navigation,
                CurrentChapter = input.CurrentChapter,
                CurrentPart = input.CurrentPart,
                LessonId = input.LessonId
            };

            GetLessonNextStepResponse response = _service.GetNextStep(request);

            return new GetLessonNextStepOutputModel { Response = response };
        }

        public GetLessonByStateOutputModel GetByState(GetLessonByStateInputModel input)
        {
            var request = new GetLessonByStateRequest
            {
                AccountId = GuidUtilities.TryParse(input.AccountId),
                State = input.State,
                Page = input.Page,
                Count = input.Count
            };

            GetLessonByStateResponse response = _service.GetByState(request);

            return new GetLessonByStateOutputModel { Response = response };
        }

        public async Task<SearchLessonOutputModel> SearchAsync(SearchLessonInputModel input)
        {
            var request = new SearchLessonRequest
            {
                Query = input.Query,
                Page = input.Page,
                Count = input.Count,
                GetAlternativePicture = input.GetAlternativePicture,
                GetThumbnailPicture = input.GetThumbnailPicture
            };

            SearchLessonResponse response = await _service.SearchAsync(request);

            return new SearchLessonOutputModel { Response = response };
        }

        public UploadLessonImageOutputModel UploadImage(UploadLessonImageInputModel input)
        {
            var request = new UploadLessonImageRequest
            {
                LessonId = GuidUtilities.TryParse(input.LessonId),
                ContentLength = input.ContentLength,
                FileName = input.FileName,
                ContentType = input.ContentType,
                Stream = input.Stream
            };

            UploadLessonImageResponse response = _service.UploadImage(request);

            return new UploadLessonImageOutputModel { Response = response };
        }

        public GetAllContentLessonOutputModel GetAllContent(GetAllContentLessonInputModel input)
        {
            var request = new GetAllContentLessonRequest
            {
                LessonId = GuidUtilities.TryParse(input.LessonId),        
            };

            GetAllContentLessonResponse response = _service.GetAllContent(request);

            return new GetAllContentLessonOutputModel { Response = response };
        }

        public PublishLessonOutputModel Publish(PublishLessonInputModel input)
        {
            var request = new PublishLessonRequest
            {
                AccountId = GuidUtilities.TryParse(input.AccountId),
                LessonId = GuidUtilities.TryParse(input.LessonId),
                UrlPath = input.UrlPath
            };

            PublishLessonResponse response = _service.Publish(request);

            return new PublishLessonOutputModel { Response = response };
        }

        public UpdateLessonOutputModel Update(UpdateLessonInputModel input)
        {
            var request = new UpdateLessonRequest
            {
                LessonId = GuidUtilities.TryParse(input.LessonId),
                Confidentiality = GuidUtilities.TryParse(input.Confidentiality),
                Study = GuidUtilities.TryParse(input.Study),
                Title = input.Title,
                Description = input.Description,
                Targets = input.Targets
            };

            UpdateLessonResponse response = _service.Update(request);

            return new UpdateLessonOutputModel() { Response = response };
        }

        public GetLessonAlternativePictureOutputModel GetAlternativePicture(GetLessonAlternativePictureInputModel input)
        {
            var request = new GetLessonAlternativePictureRequest
            {
                LessonId = GuidUtilities.TryParse(input.LessonId),
                GetThumbnailPicture = input.GetThumbnailPicture
            };

            GetLessonAlternativePictureResponse response = _service.GetAlternativePicture(request);

            return new GetLessonAlternativePictureOutputModel { Response = response };
        }

        public DeleteLessonOutputModel Delete(DeleteLessonInputModel input)
        {
            var request = new DeleteLessonRequest
            {
                AccountId = GuidUtilities.TryParse(input.AccountId),
                LessonId = GuidUtilities.TryParse(input.LessonId)
            };

            DeleteLessonResponse response = _service.Delete(request);

            return new DeleteLessonOutputModel { Response = response };
        }
    }
}
