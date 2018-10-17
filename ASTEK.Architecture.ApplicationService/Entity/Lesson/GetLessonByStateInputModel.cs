using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASTEK.Architecture.ApplicationService.Entity.Lesson
{
    public class GetLessonByStateInputModel
    {
        public string AccountId { get; set; }
        public string State { get; set; }
        public int Page { get; set; }
        public int Count { get; set; }
    }
}
