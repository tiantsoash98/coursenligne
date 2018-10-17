using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASTEK.Architecture.ApplicationService.Entity.Lesson
{
    public class SearchLessonInputModel
    {
        public string Query { get; set; }
        public int Page { get; set; }
        public int Count { get; set; }
        public bool GetAlternativePicture { get; set; }
        public bool GetThumbnailPicture { get; set; }
    }
}
