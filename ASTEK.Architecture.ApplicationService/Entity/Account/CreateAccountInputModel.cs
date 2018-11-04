using System.ComponentModel.DataAnnotations;

namespace ASTEK.Architecture.ApplicationService.Entity.Account
{
    public class CreateAccountInputModel
    {
        [Display(Name = "Display_Name", ResourceType = typeof(Infrastructure.InfrastructureStrings))]
        [Required(ErrorMessageResourceName = "ApplicationValidation_NameRequired", ErrorMessageResourceType = typeof(ApplicationStrings))]
        public string Nom { get; set; }

        [Display(Name = "Display_FirstName", ResourceType = typeof(Infrastructure.InfrastructureStrings))]
        [Required(ErrorMessageResourceName = "ApplicationValidation_FirstNameRequired", ErrorMessageResourceType = typeof(ApplicationStrings))]
        public string Prenom { get; set; }

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
        public string ConfirmPassword { get; set; }
    }
}
