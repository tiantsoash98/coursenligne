using ASTEK.Architecture.BusinessService.Entity.LessonPart;

namespace ASTEK.Architecture.BusinessService.Interface
{
    public interface ILessonPartBusinessService
    {
        CreateLessonPartResponse Create(CreateLessonPartRequest request);
        CreateAllLessonPartResponse CreateAll(CreateAllLessonPartRequest request);
        GetPartByNumberResponse GetByNumber(GetPartByNumberRequest request);
        CountPartGroupByChapterResponse Count(CountPartGroupByChapterRequest request);
        UpdateAllPartsResponse Update(UpdateAllPartsRequest request);
    }
}
