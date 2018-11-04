using System.ComponentModel.DataAnnotations;

namespace ASTEK.Architecture.ApplicationService.Entity.AnswerExercice
{
    public class UploadAnswerInputModel
    {
        [Display(Name = "Display_Comment", ResourceType = typeof(Infrastructure.InfrastructureStrings))]
        public string Comment { get; set; }

        public string AccountId { get; set; }
        public string LessonId { get; set; }
        public string FileName { get; set; }
    }
}
