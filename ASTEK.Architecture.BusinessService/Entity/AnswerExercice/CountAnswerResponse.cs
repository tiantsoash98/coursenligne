using ASTEK.Architecture.Infrastructure.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASTEK.Architecture.BusinessService.Entity.AnswerExercice
{
    public class CountAnswerResponse: Response
    {
        public string Type { get; set; }
        public bool Marked { get; set; }
    }
}
