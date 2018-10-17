using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASTEK.Architecture.ApplicationService.Entity.AccountTeacher
{
    public class CreateAccountTeacherInputModel
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

        [Display(Name = "Display_Town", ResourceType = typeof(Infrastructure.InfrastructureStrings))]
        [Required(ErrorMessageResourceName = "ApplicationValidation_TownRequired", ErrorMessageResourceType = typeof(ApplicationStrings))]
        public string Town { get; set; }

        [Display(Name = "Display_Address", ResourceType = typeof(Infrastructure.InfrastructureStrings))]
        [Required(ErrorMessageResourceName = "ApplicationValidation_AddressRequired", ErrorMessageResourceType = typeof(ApplicationStrings))]
        public string Address { get; set; }

        [Display(Name = "Display_PostalCode", ResourceType = typeof(Infrastructure.InfrastructureStrings))]
        [Required(ErrorMessageResourceName = "ApplicationValidation_PostalCodeRequired", ErrorMessageResourceType = typeof(ApplicationStrings))]
        public string PostalCode { get; set; }

        [Display(Name = "Display_PhoneNumber", ResourceType = typeof(Infrastructure.InfrastructureStrings))]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }

        [Display(Name = "Display_Email", ResourceType = typeof(Infrastructure.InfrastructureStrings))]
        [Required(ErrorMessageResourceName = "ApplicationValidation_EmailRequired", ErrorMessageResourceType = typeof(ApplicationStrings))]
        [EmailAddress(ErrorMessageResourceName = "ApplicationValidation_EmailFormat", ErrorMessageResourceType = typeof(ApplicationStrings))]
        public string Email { get; set; }

        [Display(Name = "Display_Password", ResourceType = typeof(Infrastructure.InfrastructureStrings))]
        [Required(ErrorMessageResourceName = "ApplicationValidation_PasswordRequired", ErrorMessageResourceType = typeof(ApplicationStrings))]
        [StringLength(50, MinimumLength = 8, ErrorMessageResourceName = "ApplicationValidation_PasswordLength", ErrorMessageResourceType = typeof(ApplicationStrings))]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Display_ConfirmPassword", ResourceType = typeof(ApplicationStrings))]
        [Required(ErrorMessageResourceName = "ApplicationValidation_ConfirmPasswordRequired", ErrorMessageResourceType = typeof(ApplicationStrings))]
        [StringLength(50, MinimumLength = 8, ErrorMessageResourceName = "ApplicationValidation_PasswordLength", ErrorMessageResourceType = typeof(ApplicationStrings))]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessageResourceName = "Application_PasswordMatch", ErrorMessageResourceType = typeof(ApplicationStrings))]
        public string ConfirmPassword { get; set; }
    }
}
