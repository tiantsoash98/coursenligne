using ASTEK.Architecture.Infrastructure.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASTEK.Architecture.BusinessService.Entity.Lesson
{
    public class GetBestLessonByStudyRequest: Request
    {
        public Guid StudyCode { get; set; }
        public bool GetAlternativePicture { get; set; }
        public bool GetThumbnailPicture { get; set; }
    }
}
