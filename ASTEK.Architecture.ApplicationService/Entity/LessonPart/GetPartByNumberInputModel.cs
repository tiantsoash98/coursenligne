namespace ASTEK.Architecture.ApplicationService.Entity.LessonPart
{
    public class GetPartByNumberInputModel
    {
        public string LessonId { get; set; }
        public short ChapterNumber { get; set; }
        public short Number { get; set; }
    }
}