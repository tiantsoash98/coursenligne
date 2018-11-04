using ASTEK.Architecture.Infrastructure.DTO;
using System;

namespace ASTEK.Architecture.BusinessService.Entity.AnswerExercice
{
    public class CorrectAnswerRequest: Request
    {
        public decimal Mark { get; set; }
        public string Comment { get; set; }
        public Guid AnswerId { get; set; }
        public string Valuation { get; set; }
    }
}
