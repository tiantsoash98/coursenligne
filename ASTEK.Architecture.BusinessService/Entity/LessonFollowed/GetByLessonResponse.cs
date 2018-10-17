using ASTEK.Architecture.Infrastructure.DTO;
using System.Collections.Generic;

namespace ASTEK.Architecture.BusinessService.Entity.LessonFollowed
{
    public class GetByLessonResponse: Response
    {
        public List<Domain.Entity.LessonFollowed.LessonFollowed> Followers { get; set; }
    }
}
