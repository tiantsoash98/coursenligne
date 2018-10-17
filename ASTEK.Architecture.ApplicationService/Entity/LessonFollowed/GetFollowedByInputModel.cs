using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASTEK.Architecture.ApplicationService.Entity.LessonFollowed
{
    public class GetFollowedByInputModel
    {
        public string AccountId { get; set; }
        public int Page { get; set; }
        public int Count { get; set; }
    }
}
