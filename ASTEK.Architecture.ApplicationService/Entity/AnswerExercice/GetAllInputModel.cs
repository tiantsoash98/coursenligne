namespace ASTEK.Architecture.ApplicationService.Entity.AnswerExercice
{
    public class GetAllInputModel
    {
        public string AccountId { get; set; }
        public string LessonId { get; set; }
        public int Page { get; set; }
        public int Count { get; set; }
        public string Type { get; set; }
        public bool Marked { get; set; }
    }
}
