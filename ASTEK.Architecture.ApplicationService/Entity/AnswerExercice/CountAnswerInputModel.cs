using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASTEK.Architecture.ApplicationService.Entity.AnswerExercice
{
    public class CountAnswerInputModel
    {
        public string AccountId { get; set; }
        public string LessonId { get; set; }
        public string Type { get; set; }
        public bool Marked { get; set; }
    }
}
