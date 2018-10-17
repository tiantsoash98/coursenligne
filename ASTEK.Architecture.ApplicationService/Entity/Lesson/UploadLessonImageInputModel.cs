using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASTEK.Architecture.ApplicationService.Entity.Lesson
{
    public class UploadLessonImageInputModel
    {
        public string LessonId { get; set; }
        public Stream Stream { get; set; }
        public string ContentType { get; set; }
        public int ContentLength { get; set; }
        public string FileName { get; set; }
    }
}
