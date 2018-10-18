namespace ASTEK.Architecture.ApplicationService.Entity.LessonFollowed
{
    public class GetFollowedByWithStateCodeInputModel
    {
        public string AccountId { get; set; }
        public string StateCode { get; set; }
        public int Page { get; set; }
        public int Count { get; set; }
    }
}
