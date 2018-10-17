using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASTEK.Architecture.ApplicationService.Entity.Account
{
    public class LoginAccountInputModel
    {
        [Display(Name = "Display_Email", ResourceType = typeof(Infrastructure.InfrastructureStrings))]
        [Required(ErrorMessageResourceName = "ApplicationValidation_EmailRequired", ErrorMessageResourceType = typeof(ApplicationStrings))]
        [EmailAddress(ErrorMessageResourceName = "ApplicationValidation_EmailFormat", ErrorMessageResourceType = typeof(ApplicationStrings))]
        public string Email { get; set; }

        [Display(Name = "Display_Password", ResourceType = typeof(Infrastructure.InfrastructureStrings))]
        [Required(ErrorMessageResourceName = "ApplicationValidation_PasswordRequired", ErrorMessageResourceType = typeof(ApplicationStrings))]
        [StringLength(50, MinimumLength = 8, ErrorMessageResourceName = "ApplicationValidation_PasswordLength", ErrorMessageResourceType = typeof(ApplicationStrings))]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Display_Remember", ResourceType = typeof(ApplicationStrings))]
        public bool RememberMe { get; set; }
    }
}
