namespace ASTEK.Architecture.UI.MVC.Models.Dashboard
{
    public class FollowerProgressionViewModel
    {
        public Domain.Entity.LessonFollowed.LessonFollowed Follower { get; set; }
        public string Name { get; set; }
        public int Progression { get; set; }
    }
}