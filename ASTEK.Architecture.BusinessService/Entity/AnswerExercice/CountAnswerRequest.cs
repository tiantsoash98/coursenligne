using ASTEK.Architecture.Infrastructure.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASTEK.Architecture.BusinessService.Entity.AnswerExercice
{
    public class CountAnswerRequest: Request
    {
        public Guid AccountId { get; set; }
        public Guid? LessonId { get; set; }
        public string Type { get; set; }
        public bool Marked { get; set; }
    }
}
