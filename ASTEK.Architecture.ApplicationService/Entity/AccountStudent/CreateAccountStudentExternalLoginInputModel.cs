using System;
using System.ComponentModel.DataAnnotations;

namespace ASTEK.Architecture.ApplicationService.Entity.AccountStudent
{
    public class CreateAccountStudentExternalLoginInputModel
    {
        [Display(Name = "Display_Name", ResourceType = typeof(Infrastructure.InfrastructureStrings))]
        [Required(ErrorMessageResourceName = "ApplicationValidation_NameRequired", ErrorMessageResourceType = typeof(ApplicationStrings))]
        public string Name { get; set; }

        [Display(Name = "Display_FirstName", ResourceType = typeof(Infrastructure.InfrastructureStrings))]
        [Required(ErrorMessageResourceName = "ApplicationValidation_FirstNameRequired", ErrorMessageResourceType = typeof(ApplicationStrings))]
        public string FirstName { get; set; }

        [Display(Name = "Display_BirthDay", ResourceType = typeof(Infrastructure.InfrastructureStrings))]
        [Required(ErrorMessageResourceName = "ApplicationValidation_BirthDayRequired", ErrorMessageResourceType = typeof(ApplicationStrings))]
        public DateTime BirthDay { get; set; }

        [Display(Name = "Display_Gender", ResourceType = typeof(Infrastructure.InfrastructureStrings))]
        [Required(ErrorMessageResourceName = "ApplicationValidation_GenderRequired", ErrorMessageResourceType = typeof(ApplicationStrings))]
        public string Gender { get; set; }

        [Display(Name = "Display_Country", ResourceType = typeof(Infrastructure.InfrastructureStrings))]
        [Required(ErrorMessageResourceName = "ApplicationValidation_CountryRequired", ErrorMessageResourceType = typeof(ApplicationStrings))]
        public string Country { get; set; }

        [Display(Name = "Display_Email", ResourceType = typeof(Infrastructure.InfrastructureStrings))]
        [Required(ErrorMessageResourceName = "ApplicationValidation_EmailRequired", ErrorMessageResourceType = typeof(ApplicationStrings))]
        [EmailAddress(ErrorMessageResourceName = "ApplicationValidation_EmailFormat", ErrorMessageResourceType = typeof(ApplicationStrings))]
        public string Email { get; set; }
    }
}
