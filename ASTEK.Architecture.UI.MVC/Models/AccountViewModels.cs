using ASTEK.Architecture.ApplicationService;
using ASTEK.Architecture.ApplicationService.Entity.Account;
using ASTEK.Architecture.ApplicationService.Entity.AccountStudent;
using ASTEK.Architecture.ApplicationService.Entity.AccountTeacher;
using ASTEK.Architecture.ApplicationService.Entity.Country;
using ASTEK.Architecture.ApplicationService.Entity.Gender;
using ASTEK.Architecture.ApplicationService.Entity.Study;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ASTEK.Architecture.UI.MVC.Models
{
    public class ExternalLoginAccountTypeViewModel : BaseViewModel
    {
        public string Email { get; set; }
    }

    public class ExternalLoginConfirmationViewModel : BaseViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }

    public class ExternalLoginConfirmationStudentViewModel : BaseViewModel
    {
        public CreateAccountStudentExternalLoginInputModel Input { get; set; }
        public GetAllCountryOutputModel CountryOutput { get; set; }
        public GetAllGenderOutputModel GenderOutput { get; set; }
    }

    public class ExternalLoginConfirmationTeacherViewModel : BaseViewModel
    {
        public CreateAccountTeacherExternalLoginInputModel Input { get; set; }
        public GetAllCountryOutputModel CountryOutput { get; set; }
        public GetAllGenderOutputModel GenderOutput { get; set; }
    }

    public class ExternalLoginListViewModel : BaseViewModel
    {
        public string ReturnUrl { get; set; }
    }

    public class SendCodeViewModel : BaseViewModel
    {
        public string SelectedProvider { get; set; }
        public ICollection<System.Web.Mvc.SelectListItem> Providers { get; set; }
        public string ReturnUrl { get; set; }
        public bool RememberMe { get; set; }
    }

    public class VerifyCodeViewModel : BaseViewModel
    {
        [Required]
        public string Provider { get; set; }

        [Required]
        [Display(Name = "Code")]
        public string Code { get; set; }
        public string ReturnUrl { get; set; }

        [Display(Name = "Remember this browser?")]
        public bool RememberBrowser { get; set; }

        public bool RememberMe { get; set; }
    }

    public class ForgotViewModel : BaseViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }

    public class LoginViewModel: BaseViewModel
    {
        public LoginAccountInputModel Input { get; set; }
    }

    public class RegisterViewModel: BaseViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
    }

    public class RegisterStudentViewModel: BaseViewModel
    {
        public CreateAccountStudentInputModel Input { get; set; }
        public GetAllCountryOutputModel CountryOutput { get; set; }
        public GetAllGenderOutputModel GenderOutput { get; set; }
    }

    public class RegisterTeacherViewModel: BaseViewModel
    {
        public CreateAccountTeacherInputModel Input { get; set; }
        public GetAllCountryOutputModel CountryOutput { get; set; }
        public GetAllGenderOutputModel GenderOutput { get; set; }
        public GetAllStudyOutputModel StudyOutput { get; set; }
    }

    public class ResetPasswordViewModel : BaseViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

        public string Code { get; set; }
    }

    public class ForgotPasswordViewModel : BaseViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }

    public class ManualConfirmEmailViewModel : BaseViewModel
    {
        public bool Confirmed { get; set; }
        public bool Exist { get; set; }
        public string Email { get; set; }
        public string ReturnUrl { get; set; }
    }
}
