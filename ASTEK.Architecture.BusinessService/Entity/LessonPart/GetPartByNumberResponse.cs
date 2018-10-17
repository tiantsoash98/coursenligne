using ASTEK.Architecture.Infrastructure.DTO;

namespace ASTEK.Architecture.BusinessService.Entity.LessonPart
{
    public class GetPartByNumberResponse: Response
    {
        public Domain.Entity.LessonPart.LessonPart Part { get; set; }
    }
}