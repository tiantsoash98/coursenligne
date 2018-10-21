namespace ASTEK.Architecture.ApplicationService.Entity.Comment
{
    public class GetAllCommentInputModel
    {
        public string LessonId { get; set; }
        public int Count { get; set; }
        public bool LoadAnswers { get; set; }
    }
}
