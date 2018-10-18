using ASTEK.Architecture.BusinessService.Entity.LessonFollowed;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASTEK.Architecture.BusinessService.Interface
{
    public interface ILessonFollowedBusinessService
    {
        CountTotalViewsOfAccountResponse CountTotalViewsOfAccount(CountTotalViewsOfAccountRequest request);
        CountByLessonResponse CountByLesson(CountByLessonRequest request);
        CountByAccountResponse CountByAccount(CountByAccountRequest request);
        GetByLessonResponse GetByLesson(GetByLessonRequest request);
        FinishPartResponse FinishPart(FinishPartRequest request);
        FinishLessonResponse FinishLesson(FinishLessonRequest request);
        FollowLessonResponse Follow(FollowLessonRequest request);
        GetFollowedByResponse GetFollowedBy(GetFollowedByRequest request);
        GetFollowedByWithStateCodeResponse GetFollowedByWithStateCode(GetFollowedByWithStateCodeRequest request);
    }
}
