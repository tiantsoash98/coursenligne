using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASTEK.Architecture.ApplicationService.Entity.AnswerExercice
{
    public class GetMarksOfStudentInputModel
    {
        public string AccountId { get; set; }
        public string StudyCode { get; set; }
        public int Level { get; set; }
    }
}
