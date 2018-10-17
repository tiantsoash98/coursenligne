using ASTEK.Architecture.BusinessService.Entity.LessonChapter;

namespace ASTEK.Architecture.BusinessService.Interface
{
    public interface ILessonChapterBusinessService
    {
        CreateLessonChapterResponse Create(CreateLessonChapterRequest request);
        GetChapterByNumberResponse GetByNumber(GetChapterByNumberRequest request);
        GetChapterTitleResponse GetTitle(GetChapterTitleRequest request);
        CountChapterGroupByLessonResponse Count(CountChapterGroupByLessonRequest request);
        UpdateChapterResponse Update(UpdateChapterRequest request);
    }
}
