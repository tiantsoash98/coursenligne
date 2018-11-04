using ASTEK.Architecture.Infrastructure.DTO;
using System;

namespace ASTEK.Architecture.BusinessService.Entity.Lesson
{
    public class GetBestLessonByStudyRequest: Request
    {
        public Guid StudyCode { get; set; }
        public bool GetAlternativePicture { get; set; }
        public bool GetThumbnailPicture { get; set; }
        public int Level { get; set; }
    }
}
