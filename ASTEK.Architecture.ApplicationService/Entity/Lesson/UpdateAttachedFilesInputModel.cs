namespace ASTEK.Architecture.ApplicationService.Entity.Lesson
{
    public class UpdateAttachedFilesInputModel
    {
        public string LessonId { get; set; }
        public string VideoFile { get; set; }
        public string SoundFile { get; set; }
        public string DocumentFile { get; set; }
        public string ExerciceFile { get; set; }
        public string CorrectionFile { get; set; }
    }
}
