using ASTEK.Architecture.BusinessService.Entity.Lesson;
using System.Threading.Tasks;

namespace ASTEK.Architecture.BusinessService.Interface
{
    public interface ILessonBusinessService
    {
        CountLessonPostedByResponse CountPostedBy(CountLessonPostedByRequest request);
        CreateLessonResponse Create(CreateLessonRequest request);
        GetLessonResponse Get(GetLessonRequest request);
        GetAllContentLessonResponse GetAllContent(GetAllContentLessonRequest request);
        GetBestLessonByStudyResponse GetBestByStudy(GetBestLessonByStudyRequest request);
        GetLessonMayLikeResponse GetMayLike(GetLessonMayLikeRequest request);
        GetLessonExerciceCountResponse GetExerciceCount(GetLessonExerciceCountRequest request);
        GetLessonChapterCountResponse GetChapterCount(GetLessonChapterCountRequest request);
        GetLessonNavigationResponse GetNavigation(GetLessonNavigationRequest request);
        GetLessonNextStepResponse GetNextStep(GetLessonNextStepRequest request);
        GetLessonByStateResponse GetByState(GetLessonByStateRequest request);
        IsLessonLastPartResponse IsLastPart(IsLessonLastPartRequest request);
        PublishLessonResponse Publish(PublishLessonRequest request);
        Task<SearchLessonResponse> SearchAsync(SearchLessonRequest request);
        UpdateLessonResponse Update(UpdateLessonRequest request);
        UpdateLessonImageResponse UpdateImage(UpdateLessonImageRequest request);
        UploadLessonImageResponse UploadImage(UploadLessonImageRequest request);
    }
}
