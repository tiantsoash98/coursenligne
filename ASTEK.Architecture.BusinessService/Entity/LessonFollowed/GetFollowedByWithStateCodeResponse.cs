using ASTEK.Architecture.Infrastructure.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASTEK.Architecture.BusinessService.Entity.LessonFollowed
{
    public class GetFollowedByWithStateCodeResponse: Response
    {
        public List<Domain.Entity.LessonFollowed.LessonFollowed> Followed { get; set; }
    }
}
