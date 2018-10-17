using ASTEK.Architecture.Infrastructure.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASTEK.Architecture.BusinessService.Entity.LessonPart
{
    public class CountPartGroupByChapterRequest: Request
    {
        public Guid ChapterCode { get; set; }
    }
}
