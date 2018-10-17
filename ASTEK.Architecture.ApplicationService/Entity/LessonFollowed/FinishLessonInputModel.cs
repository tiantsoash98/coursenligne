using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASTEK.Architecture.ApplicationService.Entity.LessonFollowed
{
    public class FinishLessonInputModel
    {
        public string AccountId { get; set; }
        public string LessonId { get; set; }
        public short? ChapterNumber { get; set; }
        public short? PartNumber { get; set; }
    }
}
