using System.ComponentModel.DataAnnotations;

namespace ASTEK.Architecture.ApplicationService.Entity.AnswerExercice
{
    public class CorrectAnswerInputModel
    {
        [Display(Name = "Display_Comment", ResourceType = typeof(Infrastructure.InfrastructureStrings))]
        public string Comment { get; set; }

        [Display(Name = "Note /20")]
        [Required]
        public decimal Mark { get; set; }

        [Display(Name = "Appréciation")]
        public string Valuation { get; set; }

        public string AnswerId { get; set; }
    }
}
