using ASTEK.Architecture.Infrastructure.DTO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASTEK.Architecture.BusinessService.Entity.Lesson
{
    public class UploadLessonImageRequest: Request
    {
        public Guid LessonId { get; set; }
        public Stream Stream { get; set; }
        public string ContentType { get; set; }
        public int ContentLength { get; set; }
        public string FileName { get; set; }
    }
}
