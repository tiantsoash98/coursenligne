namespace ASTEK.Architecture.ApplicationService.Entity.LessonChapter
{
    public class GetChapterByNumberInputModel
    {
        public string LessonId { get; set; }
        public short Number { get; set; }
        public bool LoadChildren { get; set; }
    }
}
