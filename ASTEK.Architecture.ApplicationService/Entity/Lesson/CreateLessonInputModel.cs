using System;
using System.ComponentModel.DataAnnotations;

namespace ASTEK.Architecture.ApplicationService.Entity.Lesson
{
    public class CreateLessonInputModel
    {
        [Display(Name = "Display_Title", ResourceType = typeof(Infrastructure.InfrastructureStrings))]
        [Required(ErrorMessageResourceName = "ApplicationValidation_TitleRequired", ErrorMessageResourceType = typeof(ApplicationStrings))]
        [StringLength(200, ErrorMessageResourceName = "ApplicationValidation_TitleLength", ErrorMessageResourceType = typeof(ApplicationStrings))]
        public string Title { get; set; }

        [Display(Name = "Display_Study", ResourceType = typeof(Infrastructure.InfrastructureStrings))]
        [Required(ErrorMessageResourceName = "ApplicationValidation_StudyRequired", ErrorMessageResourceType = typeof(ApplicationStrings))]
        public string Study { get; set; }

        [Display(Name = "Display_Level", ResourceType = typeof(Infrastructure.InfrastructureStrings))]
        public int Level { get; set; }

        [Display(Name = "Display_Description", ResourceType = typeof(Infrastructure.InfrastructureStrings))]
        [Required(ErrorMessageResourceName = "ApplicationValidation_DescriptionRequired", ErrorMessageResourceType = typeof(ApplicationStrings))]
        [StringLength(1000, ErrorMessageResourceName = "ApplicationValidation_DescriptionLength", ErrorMessageResourceType = typeof(ApplicationStrings))]
        public string Description { get; set; }

        [Display(Name = "Display_Target", ResourceType = typeof(Infrastructure.InfrastructureStrings))]
        [Required(ErrorMessageResourceName = "ApplicationValidation_TargetRequired", ErrorMessageResourceType = typeof(ApplicationStrings))]
        [StringLength(1000, ErrorMessageResourceName = "ApplicationValidation_TargetLength", ErrorMessageResourceType = typeof(ApplicationStrings))]
        public string Targets { get; set; }

        public string Confidentiality { get; set; }
        public Guid AccountId { get; set; }
    }
}