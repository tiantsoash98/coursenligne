using ASTEK.Architecture.Infrastructure.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASTEK.Architecture.BusinessService.Entity.Lesson
{
    public class GetLessonNextStepResponse: Response
    {
        public bool Exist { get; set; }
        public string Type { get; set; }
        public string Title { get; set; }
        public string LessonId { get; set; }
        public short NextChapterNumber { get; set; }
        public short NextPartNumber { get; set; }
        public short CurrentChapterNumber { get; set; }
        public short CurrentPartNumber { get; set; }
    }
}
