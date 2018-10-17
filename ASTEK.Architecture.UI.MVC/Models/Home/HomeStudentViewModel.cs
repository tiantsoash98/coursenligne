using ASTEK.Architecture.Domain.Entity.Study;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASTEK.Architecture.UI.MVC.Models.Home
{
    public class HomeStudentViewModel: BaseViewModel
    {
        public List<Domain.Entity.Lesson.Lesson> MayLike { get; set; }
    }
}