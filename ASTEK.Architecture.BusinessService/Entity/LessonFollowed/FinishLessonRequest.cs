using ASTEK.Architecture.Infrastructure.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASTEK.Architecture.BusinessService.Entity.LessonFollowed
{
    public class FinishLessonRequest: Request
    {
        public Guid AccountId { get; set; }
        public Guid LessonId { get; set; }
        public short? ChapterNumber { get; set; }
        public short? PartNumber { get; set; }
    }
}
