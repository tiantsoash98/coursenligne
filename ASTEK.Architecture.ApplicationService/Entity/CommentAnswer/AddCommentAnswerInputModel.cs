using System.ComponentModel.DataAnnotations;

namespace ASTEK.Architecture.ApplicationService.Entity.CommentAnswer
{
    public class AddCommentAnswerInputModel
    {
        [Display(Name = "Display_Comment", ResourceType = typeof(Infrastructure.InfrastructureStrings))]
        [Required(ErrorMessageResourceName = "ApplicationValidation_ContentRequired", ErrorMessageResourceType = typeof(ApplicationStrings))]
        [StringLength(2000, ErrorMessageResourceName = "ApplicationValidation_ContentLength", ErrorMessageResourceType = typeof(ApplicationStrings))]
        public string Content { get; set; }

        public string CommentId { get; set; }
        public string LessonId { get; set; }
        public string AccountId { get; set; }
    }
}
