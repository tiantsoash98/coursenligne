using ASTEK.Architecture.Infrastructure.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASTEK.Architecture.BusinessService.Entity.LessonChapter
{
    public class GetChapterByNumberResponse: Response
    {
        public Domain.Entity.LessonChapter.LessonChapter Chapter { get; set; }
    }
}
