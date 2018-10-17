using ASTEK.Architecture.Infrastructure.DTO;
using ASTEK.Architecture.Infrastructure.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASTEK.Architecture.BusinessService.Entity.Lesson
{
    public class GetLessonNextStepRequest: Request
    {
        public LessonNavigation Navigation { get; set; }
        public short CurrentChapter { get; set; }
        public short CurrentPart { get; set; }
        public string LessonId { get; set; }
    }
}
