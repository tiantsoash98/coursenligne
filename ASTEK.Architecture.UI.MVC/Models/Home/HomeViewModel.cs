using System.Collections.Generic;

namespace ASTEK.Architecture.UI.MVC.Models.Home
{
    public class HomeViewModel: BaseViewModel
    {
        public List<Domain.Entity.Lesson.Lesson> MayLike { get; set; }
        public List<Domain.Entity.Lesson.Lesson> Recents { get; set; }
    }
}