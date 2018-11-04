using ASTEK.Architecture.Infrastructure.DTO;
using System;

namespace ASTEK.Architecture.BusinessService.Entity.Lesson
{
    public class UpdateAttachedFilesRequest: Request
    {
        public Guid LessonId { get; set; }
        public string VideoFile { get; set; }
        public string SoundFile { get; set; }
        public string DocumentFile { get; set; }
        public string ExerciceFile { get; set; }
        public string CorrectionFile { get; set; }
    }
}
