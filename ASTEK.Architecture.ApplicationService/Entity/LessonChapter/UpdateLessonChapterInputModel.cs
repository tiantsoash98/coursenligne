using System.ComponentModel.DataAnnotations;

namespace ASTEK.Architecture.ApplicationService.Entity.LessonChapter
{
    public class UpdateLessonChapterInputModel
    {
        [Display(Name = "Display_Title", ResourceType = typeof(Infrastructure.InfrastructureStrings))]
        [Required(ErrorMessageResourceName = "ApplicationValidation_TitleRequired", ErrorMessageResourceType = typeof(ApplicationStrings))]
        [StringLength(200, ErrorMessageResourceName = "ApplicationValidation_TitleLength", ErrorMessageResourceType = typeof(ApplicationStrings))]
        public string Title { get; set; }

        [Display(Name = "Display_Description", ResourceType = typeof(Infrastructure.InfrastructureStrings))]
        [StringLength(2000, ErrorMessageResourceName = "ApplicationValidation_DescriptionLength", ErrorMessageResourceType = typeof(ApplicationStrings))]
        public string Description { get; set; }

        [Display(Name = "Display_Content", ResourceType = typeof(Infrastructure.InfrastructureStrings))]
        [Required(ErrorMessageResourceName = "ApplicationValidation_ContentRequired", ErrorMessageResourceType = typeof(ApplicationStrings))]
        public string Content { get; set; }

        [Display(Name = "Display_Hour", ResourceType = typeof(Infrastructure.InfrastructureStrings))]
        [Range(0, 99, ErrorMessageResourceName = "ApplicationValidation_ValueRange", ErrorMessageResourceType = typeof(ApplicationStrings))]
        public int Hours { get; set; }

        [Display(Name = "Display_Minute", ResourceType = typeof(Infrastructure.InfrastructureStrings))]
        [Range(0, 99, ErrorMessageResourceName = "ApplicationValidation_ValueRange", ErrorMessageResourceType = typeof(ApplicationStrings))]
        public int Minutes { get; set; }

        public string LessonId { get; set; }
        public short ChapterNumber { get; set; }
    }
}
