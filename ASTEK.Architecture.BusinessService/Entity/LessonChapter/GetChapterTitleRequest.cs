using ASTEK.Architecture.Infrastructure.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASTEK.Architecture.BusinessService.Entity.LessonChapter
{
    public class GetChapterTitleRequest: Request
    {
        public Guid LessonId { get; set; }
        public short ChapterNumber { get; set; }
    }
}
