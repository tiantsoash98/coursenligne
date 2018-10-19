namespace ASTEK.Architecture.ApplicationService.Entity.LessonFollowed
{
    public class GetFollowedByWithStateInputModel
    {
        public string AccountId { get; set; }
        public string State { get; set; }
        public int Page { get; set; }
        public int Count { get; set; }
    }
}
