using ASTEK.Architecture.Infrastructure.DTO;
using System.Collections.Generic;

namespace ASTEK.Architecture.BusinessService.Entity.AnswerExercice
{
    public class GetAllResponse: Response
    {
        public List<Domain.Entity.AnswerExercice.AnswerExercice> AnswerExercices { get; set; }
        public string Type { get; set; }
        public bool Marked { get; set; }
    }
}
