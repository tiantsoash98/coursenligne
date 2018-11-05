using System;
using System.ComponentModel.DataAnnotations;

namespace ASTEK.Architecture.ApplicationService.Entity.AccountStudent
{
    public class UpdateAccountStudentInputModel
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

        [Display(Name = "Display_University", ResourceType = typeof(Infrastructure.InfrastructureStrings))]
        public string University { get; set; }

        [Display(Name = "Display_Study", ResourceType = typeof(Infrastructure.InfrastructureStrings))]
        public string Study { get; set; }

        [Display(Name = "Display_Level", ResourceType = typeof(Infrastructure.InfrastructureStrings))]
        public int Level { get; set; }

        [Display(Name = "Display_PhoneNumber", ResourceType = typeof(Infrastructure.InfrastructureStrings))]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }

        public string AccountId { get; set; }
        public string Picture { get; set; }
    }
}
