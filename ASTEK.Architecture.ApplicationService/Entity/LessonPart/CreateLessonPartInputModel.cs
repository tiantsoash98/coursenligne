using System;
using System.ComponentModel.DataAnnotations;

namespace ASTEK.Architecture.ApplicationService.Entity.LessonPart
{
    public class CreateLessonPartInputModel
    {
        [Display(Name = "Display_Title", ResourceType = typeof(Infrastructure.InfrastructureStrings))]
        [Required(ErrorMessageResourceName = "ApplicationValidation_TitleRequired", ErrorMessageResourceType = typeof(ApplicationStrings))]
        [StringLength(200, ErrorMessageResourceName = "ApplicationValidation_TitleLength", ErrorMessageResourceType = typeof(ApplicationStrings))]
        public string Title { get; set; }

        [Display(Name = "Display_Content", ResourceType = typeof(Infrastructure.InfrastructureStrings))]
        [Required(ErrorMessageResourceName = "ApplicationValidation_ContentRequired", ErrorMessageResourceType = typeof(ApplicationStrings))]
        public string Content { get; set; }

        public Guid ChapterCode { get; set; }
    }
}
