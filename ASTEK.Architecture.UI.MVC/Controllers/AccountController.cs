using ASTEK.Architecture.ApplicationService.Entity.Account;
using ASTEK.Architecture.ApplicationService.Entity.AccountStudent;
using ASTEK.Architecture.ApplicationService.Entity.AccountTeacher;
using ASTEK.Architecture.ApplicationService.Entity.Country;
using ASTEK.Architecture.ApplicationService.Entity.Gender;
using ASTEK.Architecture.ApplicationService.Entity.Study;
using ASTEK.Architecture.Domain.Entity.Account;
using ASTEK.Architecture.Domain.Entity.AccountStudent;
using ASTEK.Architecture.Domain.Entity.AccountTeacher;
using ASTEK.Architecture.Infrastructure.Domain;
using ASTEK.Architecture.UI.MVC.Models;
using ASTEK.Architecture.UI.MVC.Models.Account;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using System;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace ASTEK.Architecture.UI.MVC.Controllers
{
    [Authorize]
    public class AccountController : BaseController
    {
        private ApplicationSignInManager _signInManager;
        private ApplicationUserManager _userManager;
        private GetAllCountryOutputModel _countryOutput;
        private GetAllGenderOutputModel _genderOutput;
        private GetAllStudyOutputModel _studyOutput;

        public AccountController()
        {
        }

        public AccountController(ApplicationUserManager userManager, ApplicationSignInManager signInManager)
        {
            UserManager = userManager;
            SignInManager = signInManager;
        }

        public ApplicationSignInManager SignInManager
        {
            get
            {
                return _signInManager ?? HttpContext.GetOwinContext().Get<ApplicationSignInManager>();
            }
            private set
            {
                _signInManager = value;
            }
        }

        public ApplicationUserManager UserManager
        {
            get
            {
                return _userManager ?? HttpContext.GetOwinContext().GetUserManager<ApplicationUserManager>();
            }
            private set
            {
                _userManager = value;
            }
        }

        public GetAllCountryOutputModel CountryOutputModel
        {
            get
            {
                return _countryOutput ?? new CountryAppService().GetAll(new GetAllCountryInputModel());
            }
            set
            {
                _countryOutput = value;
            }
        }

        public GetAllGenderOutputModel GenderOutputModel
        {
            get
            {
                return _genderOutput ?? new GenderAppService().GetAll(new GetAllGenderInputModel { Culture = CurrentCultureCode });
            }
            set
            {
                _genderOutput = value;
            }
        }

        public GetAllStudyOutputModel StudyOutputModel
        {
            get
            {
                return _studyOutput ?? new StudyAppService().GetAll(new GetAllStudyInputModel());
            }
            set
            {
                _studyOutput = value;
            }
        }

        //
        // GET: /Account/Login
        [AllowAnonymous]
        public ActionResult Login(string returnUrl)
        {
            ViewBag.ReturnUrl = returnUrl;
            return View(new LoginViewModel());
        }

        //
        // POST: /Account/Login
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Login(LoginViewModel model, string returnUrl)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var service = new AccountAppService();
            var output = service.Login(model.Input);

            if (!output.Response.Success)
            {
                ModelState.AddModelError("", output.Response.Exception);
                return View(model);
            }

            // This doesn't count login failures towards account lockout
            // To enable password failures to trigger account lockout, change to shouldLockout: true
            var result = await SignInManager.PasswordSignInAsync(model.Input.Email, model.Input.Password, model.Input.RememberMe, shouldLockout: false);
            switch (result)
            {
                case SignInStatus.Success:
                    return RedirectToUserRoleHomePage(returnUrl, "Login");
                case SignInStatus.LockedOut:
                    return View("Lockout");
                case SignInStatus.RequiresVerification:
                    return RedirectToAction("SendCode", new { ReturnUrl = returnUrl, RememberMe = model.Input.RememberMe });
                default:
                    ModelState.AddModelError("", BusinessService.BusinessStrings.AccountNotFoundException);
                    return View(model);
            }
        }

        //
        // GET: /Account/VerifyCode
        [AllowAnonymous]
        public async Task<ActionResult> VerifyCode(string provider, string returnUrl, bool rememberMe)
        {
            // Require that the user has already logged in via username/password or external login
            if (!await SignInManager.HasBeenVerifiedAsync())
            {
                return View("Error");
            }
            return View(new VerifyCodeViewModel { Provider = provider, ReturnUrl = returnUrl, RememberMe = rememberMe });
        }

        //
        // POST: /Account/VerifyCode
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> VerifyCode(VerifyCodeViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            // The following code protects for brute force attacks against the two factor codes. 
            // If a user enters incorrect codes for a specified amount of time then the user account 
            // will be locked out for a specified amount of time. 
            // You can configure the account lockout settings in IdentityConfig
            var result = await SignInManager.TwoFactorSignInAsync(model.Provider, model.Code, isPersistent: model.RememberMe, rememberBrowser: model.RememberBrowser);
            switch (result)
            {
                case SignInStatus.Success:
                    return RedirectToLocal(model.ReturnUrl);
                case SignInStatus.LockedOut:
                    return View("Lockout");
                default:
                    ModelState.AddModelError("", "Invalid code.");
                    return View(model);
            }
        }

        //
        // GET: /Account/RegisterStudent
        [AllowAnonymous]
        public ActionResult RegisterStudent()
        {
            var viewModel = new RegisterStudentViewModel
            {
                CountryOutput = CountryOutputModel,
                GenderOutput = GenderOutputModel,
                LevelList = new SelectList(Level.GetLevels(), "Value", "Wording")
            };

            return View(viewModel);
        }

        //
        // POST: /Account/RegisterStudent
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> RegisterStudent(RegisterStudentViewModel model)
        {
            if (ModelState.IsValid)
            {
                var accountAppService = new AccountStudentAppService();
                CreateAccountStudentOutputModel output = accountAppService.Create(model.Input);

                if (!output.Response.Success)
                {
                    foreach (var error in output.Response.Errors)
                    {
                        ModelState.AddModelError("ValidatorErrors", error.ErrorMessage);
                    }

                    model.CountryOutput = CountryOutputModel;
                    model.GenderOutput = GenderOutputModel;
                    model.LevelList = new SelectList(Level.GetLevels(), "Value", "Wording");

                    return View(model);
                }

                Account account = AssignAccountStudentProperties(model.Input);

                var user = new ApplicationUser
                {
                    UserName = model.Input.Email,
                    Email = model.Input.Email,
                    Account = account
                };

                var result = await UserManager.CreateAsync(user, model.Input.Password);
                if (result.Succeeded)
                {
                    result = AddUserToRole(user, UserRole.Student);
                    if (result.Succeeded)
                    {
                        await SignInManager.SignInAsync(user, isPersistent: false, rememberBrowser: false);

                        // For more information on how to enable account confirmation and password reset please visit http://go.microsoft.com/fwlink/?LinkID=320771
                        // Send an email with this link
                        string code = await UserManager.GenerateEmailConfirmationTokenAsync(user.Id);
                        var callbackUrl = Url.Action("ConfirmEmail", "Account", new { userId = user.Id, code = code }, protocol: Request.Url.Scheme);
                        await UserManager.SendEmailAsync(user.Id, "Confirm your account", "Please confirm your account by clicking <a href=\"" + callbackUrl + "\">here</a>");

                        return RedirectToUserRoleHomePage(UserRole.Student);
                    }
                }
                AddErrors(result);
            }

            model.CountryOutput = CountryOutputModel;
            model.GenderOutput = GenderOutputModel;

            // If we got this far, something failed, redisplay form
            return View(model);
        }

        //
        // GET: /Account/RegisterTeacher
        [AllowAnonymous]
        public ActionResult RegisterTeacher()
        {
            var viewModel = new RegisterTeacherViewModel()
            {
                CountryOutput = CountryOutputModel,
                GenderOutput = GenderOutputModel,
                StudyOutput = StudyOutputModel
            };

            return View(viewModel);
        }

        //
        // POST: /Account/RegisterTeacher
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> RegisterTeacher(RegisterTeacherViewModel model)
        {
            if (ModelState.IsValid)
            {
                var accountAppService = new AccountTeacherAppService();
                CreateAccountTeacherOutputModel output = accountAppService.Create(model.Input);

                if (!output.Response.Success)
                {
                    foreach (var error in output.Response.Errors)
                    {
                        ModelState.AddModelError("ValidatorErrors", error.ErrorMessage);
                    }

                    model.CountryOutput = CountryOutputModel;
                    model.GenderOutput = GenderOutputModel;

                    return View(model);
                }

                Account account = AssignAccountTeacherProperties(model.Input);

                var user = new ApplicationUser
                {
                    UserName = model.Input.Email,
                    Email = model.Input.Email,
                    Account = account
                };

                var result = await UserManager.CreateAsync(user, model.Input.Password);
                if (result.Succeeded)
                {
                    result = AddUserToRole(user, UserRole.Teacher);
                    if (result.Succeeded)
                    {
                        await SignInManager.SignInAsync(user, isPersistent: false, rememberBrowser: false);

                        // For more information on how to enable account confirmation and password reset please visit http://go.microsoft.com/fwlink/?LinkID=320771
                        // Send an email with this link
                        string code = await UserManager.GenerateEmailConfirmationTokenAsync(user.Id);
                        var callbackUrl = Url.Action("ConfirmEmail", "Account", new { userId = user.Id, code = code }, protocol: Request.Url.Scheme);
                        await UserManager.SendEmailAsync(user.Id, "Confirm your account", "Please confirm your account by clicking <a href=\"" + callbackUrl + "\">here</a>");

                        return RedirectToUserRoleHomePage(UserRole.Teacher);
                    }
                }
                AddErrors(result);
            }

            model.CountryOutput = CountryOutputModel;
            model.GenderOutput = GenderOutputModel;
            model.StudyOutput = StudyOutputModel;

            // If we got this far, something failed, redisplay form
            return View(model);
        }

        [Authorize]
        [HttpGet]
        public ActionResult Update(string status)
        {
            var service = new AccountAppService();

            var infosInput = new GetAllInformationsAccountInputModel
            {
                AccountId = GetAccountLogged().Id.ToString()
            };

            var infosOutput = service.GetAllInformations(infosInput);

            if (!infosOutput.Response.Success)
            {
                ViewBag.Exception = infosOutput.Response.Exception;
                return View("Error");
            }

            UserRole role = GetUserLoggedRole();

            if (role == UserRole.Student)
            {
                var updateInput = GetUpdateStudentInputModel(infosOutput.Response.Account);

                var profileVM = new UpdateAccountStudentViewModel
                {
                    Input = updateInput,
                    CountryOutput = CountryOutputModel,
                    GenderOutput = GenderOutputModel,
                    Status = status,
                    EmailConfirmed = GetUserLogged().EmailConfirmed,
                    HasPassword = HasPassword(),
                    LevelList = new SelectList(Level.GetLevels(), "Value", "Wording"),
                };

                return View("UpdateStudent", profileVM);
            }
            else if (role == UserRole.Teacher)
            {
                var updateInput = GetUpdateTeacherInputModel(infosOutput.Response.Account);

                var profileVM = new UpdateAccountTeacherViewModel
                {
                    Input = updateInput,
                    CountryOutput = CountryOutputModel,
                    GenderOutput = GenderOutputModel,
                    Status = status,
                    EmailConfirmed = GetUserLogged().EmailConfirmed,
                    HasPassword = HasPassword()
                };

                return View("UpdateTeacher", profileVM);
            }

            return RedirectToAction("Index", "Home");
        }

        [Authorize]
        [HttpGet]
        public ActionResult UpdateTeacher()
        {
            return RedirectToAction("Update");
        }

        [Authorize]
        [HttpPost]
        public ActionResult UpdateTeacher(UpdateAccountTeacherViewModel model, HttpPostedFileBase image)
        {
            if (!ModelState.IsValid)
            {
                model.CountryOutput = CountryOutputModel;
                model.GenderOutput = GenderOutputModel;
                return View();
            }

            var service = new AccountTeacherAppService();
            var output = service.Update(model.Input);

            if (!output.Response.Success)
            {
                if (output.Response.Exception != null)
                {
                    ModelState.AddModelError("Error", output.Response.Exception.Message);
                }

                if (output.Response.ValidatorErrors != null)
                {
                    foreach (var error in output.Response.ValidatorErrors)
                    {
                        ModelState.AddModelError("ValidatorErrors", error.ErrorMessage);
                    }
                }

                model.CountryOutput = CountryOutputModel;
                model.GenderOutput = GenderOutputModel;
                return View(model);
            }

            if (image != null && image.ContentLength > 0)
            {
                var imageInput = new UploadAccountImageInputModel
                {
                    Stream = image.InputStream,
                    ContentLength = image.ContentLength,
                    ContentType = image.ContentType,
                    FileName = image.FileName,
                    Account = model.Input.AccountId
                };

                var accountService = new AccountAppService();
                var imageOutput = accountService.UploadImage(imageInput);

                if (!imageOutput.Response.Success)
                {
                    if (imageOutput.Response.Exception != null)
                    {
                        ModelState.AddModelError("ImageError", imageOutput.Response.Exception);
                    }

                    if (imageOutput.Response.ValidationFailures != null)
                    {
                        foreach (var error in imageOutput.Response.ValidationFailures)
                        {
                            ModelState.AddModelError("ImageValidatorErrors", error.ErrorMessage);
                        }
                    }

                    model.CountryOutput = CountryOutputModel;
                    model.GenderOutput = GenderOutputModel;
                    return View(model);
                }
            }

            return RedirectToAction("Update", new { status = "success" });
        }

        [Authorize]
        [HttpGet]
        public ActionResult UpdateStudent()
        {
            return RedirectToAction("Update");
        }

        [Authorize]
        [HttpPost]
        public ActionResult UpdateStudent(UpdateAccountStudentViewModel model, HttpPostedFileBase image)
        {
            if (!ModelState.IsValid)
            {
                model.CountryOutput = CountryOutputModel;
                model.GenderOutput = GenderOutputModel;
                model.LevelList = new SelectList(Level.GetLevels(), "Value", "Wording");
                return View();
            }

            var service = new AccountStudentAppService();
            var output = service.Update(model.Input);

            if (!output.Response.Success)
            {
                if (output.Response.Exception != null)
                {
                    ModelState.AddModelError("Error", output.Response.Exception.Message);
                }

                if (output.Response.ValidatorErrors != null)
                {
                    foreach (var error in output.Response.ValidatorErrors)
                    {
                        ModelState.AddModelError("ValidatorErrors", error.ErrorMessage);
                    }
                }

                model.CountryOutput = CountryOutputModel;
                model.GenderOutput = GenderOutputModel;
                model.LevelList = new SelectList(Level.GetLevels(), "Value", "Wording");
                return View(model);
            }

            if (image != null && image.ContentLength > 0)
            {
                var imageInput = new UploadAccountImageInputModel
                {
                    Stream = image.InputStream,
                    ContentLength = image.ContentLength,
                    ContentType = image.ContentType,
                    FileName = image.FileName,
                    Account = model.Input.AccountId
                };

                var accountService = new AccountAppService();
                var imageOutput = accountService.UploadImage(imageInput);

                if (!imageOutput.Response.Success)
                {
                    if (imageOutput.Response.Exception != null)
                    {
                        ModelState.AddModelError("ImageError", imageOutput.Response.Exception);
                    }

                    if (imageOutput.Response.ValidationFailures != null)
                    {
                        foreach (var error in imageOutput.Response.ValidationFailures)
                        {
                            ModelState.AddModelError("ImageValidatorErrors", error.ErrorMessage);
                        }
                    }

                    model.CountryOutput = CountryOutputModel;
                    model.GenderOutput = GenderOutputModel;
                    return View(model);
                }
            }

            return RedirectToAction("Update", new { status = "success" });
        }

        //
        // GET: /Account/ConfirmEmail
        [AllowAnonymous]
        public async Task<ActionResult> ManualConfirmEmail(string returnUrl)
        {
            if (!User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Index", "Home");
            }

            var user = GetUserLogged();

            var confirmed = await UserManager.IsEmailConfirmedAsync(user.Id);

            if (!confirmed)
            {
                try
                {
                    string code = await UserManager.GenerateEmailConfirmationTokenAsync(user.Id);
                    var callbackUrl = Url.Action("ConfirmEmail", "Account", new { userId = user.Id, code }, protocol: Request.Url.Scheme);
                    await UserManager.SendEmailAsync(user.Id, "Confirm your account", "Please confirm your account by clicking <a href=\"" + callbackUrl + "\">here</a>");
                }
                catch
                {
                    var vm = new ManualConfirmEmailViewModel
                    {
                        Exist = false,
                        Confirmed = confirmed,
                        Email = user.Email,
                        ReturnUrl = returnUrl
                    };

                    return View(vm);
                }
            }

            var confirmVM = new ManualConfirmEmailViewModel
            {
                Exist = true,
                Confirmed = confirmed,
                Email = user.Email,
                ReturnUrl = returnUrl
            };

            return View(confirmVM);
        }

        //
        // GET: /Account/ConfirmEmail
        [AllowAnonymous]
        public async Task<ActionResult> ConfirmEmail(string userId, string code)
        {
            if (userId == null || code == null)
            {
                return View("Error");
            }
            var result = await UserManager.ConfirmEmailAsync(userId, code);

            if (!result.Succeeded)
            {
                return View("Error");
            }

            return View("ConfirmEmail", new BaseViewModel());
        }

        //
        // GET: /Account/ForgotPassword
        [AllowAnonymous]
        public ActionResult ForgotPassword()
        {
            return View(new ForgotPasswordViewModel());
        }

        //
        // POST: /Account/ForgotPassword
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> ForgotPassword(ForgotPasswordViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = await UserManager.FindByNameAsync(model.Email);
                //if (user == null || !(await UserManager.IsEmailConfirmedAsync(user.Id)))
                //{
                //    // Don't reveal that the user does not exist or is not confirmed
                //    return View("ForgotPasswordConfirmation", new BaseViewModel());
                //}

                // For more information on how to enable account confirmation and password reset please visit http://go.microsoft.com/fwlink/?LinkID=320771
                // Send an email with this link
                string code = await UserManager.GeneratePasswordResetTokenAsync(user.Id);
                var callbackUrl = Url.Action("ResetPassword", "Account", new { userId = user.Id, code = code }, protocol: Request.Url.Scheme);
                await UserManager.SendEmailAsync(user.Id, "Reset Password", "Please reset your password by clicking <a href=\"" + callbackUrl + "\">here</a>");

                return RedirectToAction("ForgotPasswordConfirmation", "Account");
            }

            // If we got this far, something failed, redisplay form
            return View(model);
        }

        //
        // GET: /Account/ForgotPasswordConfirmation
        [AllowAnonymous]
        public ActionResult ForgotPasswordConfirmation()
        {
            return View(new BaseViewModel());
        }

        //
        // GET: /Account/ResetPassword
        [AllowAnonymous]
        public ActionResult ResetPassword(string code)
        {
            return code == null ? View("Error") : View(new ResetPasswordViewModel());
        }

        //
        // POST: /Account/ResetPassword
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> ResetPassword(ResetPasswordViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var user = await UserManager.FindByNameAsync(model.Email);
            if (user == null)
            {
                // Don't reveal that the user does not exist
                return RedirectToAction("ResetPasswordConfirmation", "Account");
            }
            var result = await UserManager.ResetPasswordAsync(user.Id, model.Code, model.Password);
            if (result.Succeeded)
            {
                return RedirectToAction("ResetPasswordConfirmation", "Account");
            }
            AddErrors(result);
            return View(new ResetPasswordViewModel());
        }

        //
        // GET: /Account/ResetPasswordConfirmation
        [AllowAnonymous]
        public ActionResult ResetPasswordConfirmation()
        {
            return View(new BaseViewModel());
        }

        //
        // POST: /Account/ExternalLogin
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult ExternalLogin(string provider, string returnUrl)
        {
            // Request a redirect to the external login provider
            return new ChallengeResult(provider, Url.Action("ExternalLoginCallback", "Account", new { ReturnUrl = returnUrl }));
        }

        //
        // GET: /Account/SendCode
        [AllowAnonymous]
        public async Task<ActionResult> SendCode(string returnUrl, bool rememberMe)
        {
            var userId = await SignInManager.GetVerifiedUserIdAsync();
            if (userId == null)
            {
                return View("Error");
            }
            var userFactors = await UserManager.GetValidTwoFactorProvidersAsync(userId);
            var factorOptions = userFactors.Select(purpose => new SelectListItem { Text = purpose, Value = purpose }).ToList();
            return View(new SendCodeViewModel { Providers = factorOptions, ReturnUrl = returnUrl, RememberMe = rememberMe });
        }

        //
        // POST: /Account/SendCode
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> SendCode(SendCodeViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            // Generate the token and send it
            if (!await SignInManager.SendTwoFactorCodeAsync(model.SelectedProvider))
            {
                return View("Error");
            }
            return RedirectToAction("VerifyCode", new { Provider = model.SelectedProvider, ReturnUrl = model.ReturnUrl, RememberMe = model.RememberMe });
        }

        //
        // GET: /Account/ExternalLoginCallback
        [AllowAnonymous]
        public async Task<ActionResult> ExternalLoginCallback(string returnUrl)
        {
            var loginInfo = await AuthenticationManager.GetExternalLoginInfoAsync();
            if (loginInfo == null)
            {
                return RedirectToAction("Login");
            }


            // Sign in the user with this external login provider if the user already has a login
            var result = await SignInManager.ExternalSignInAsync(loginInfo, isPersistent: false);
            switch (result)
            {
                case SignInStatus.Success:
                    return RedirectToLocal(returnUrl);
                case SignInStatus.LockedOut:
                    return View("Lockout");
                case SignInStatus.RequiresVerification:
                    return RedirectToAction("SendCode", new { ReturnUrl = returnUrl, RememberMe = false });
                default:
                    // If the user does not have an account, then prompt the user to create an account
                    ViewBag.ReturnUrl = returnUrl;
                    ViewBag.LoginProvider = loginInfo.Login.LoginProvider;
                    return View("ExternalLoginAccountType", new ExternalLoginAccountTypeViewModel { Email = loginInfo.Email });
            }
        }

        [AllowAnonymous]
        public async Task<ActionResult> ExternalLoginStudentConfirmation()
        {
            var loginInfo = await AuthenticationManager.GetExternalLoginInfoAsync();
            if (loginInfo == null)
            {
                return RedirectToAction("Login");
            }

            var input = new CreateAccountStudentExternalLoginInputModel
            {
                Email = loginInfo.Email
            };

            if (loginInfo.Login.LoginProvider == "Google")
            {
                var externalIdentity = AuthenticationManager.GetExternalIdentityAsync(DefaultAuthenticationTypes.ExternalCookie);
                var emailClaim = externalIdentity.Result.Claims.FirstOrDefault(c => c.Type == ClaimTypes.Email);
                var lastNameClaim = externalIdentity.Result.Claims.FirstOrDefault(c => c.Type == ClaimTypes.Surname);
                var givenNameClaim = externalIdentity.Result.Claims.FirstOrDefault(c => c.Type == ClaimTypes.GivenName);

                input.FirstName = givenNameClaim.Value;
                input.Name = lastNameClaim.Value;
            }

            var viewModel = new ExternalLoginConfirmationStudentViewModel()
            {
                Input = input,
                CountryOutput = CountryOutputModel,
                GenderOutput = GenderOutputModel
            };

            return View(viewModel);
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> ExternalLoginStudentConfirmation(ExternalLoginConfirmationStudentViewModel model)
        {
            if (User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Update");
            }

            if (ModelState.IsValid)
            {
                // Get the information about the user from the external login provider
                var info = await AuthenticationManager.GetExternalLoginInfoAsync();
                if (info == null)
                {
                    return View("ExternalLoginFailure");
                }

                var accountAppService = new AccountStudentAppService();
                CreateAccountStudentExternalLoginOutputModel output = accountAppService.CreateExternalLogin(model.Input);

                if (!output.Response.Success)
                {
                    foreach (var error in output.Response.Errors)
                    {
                        ModelState.AddModelError("ValidatorErrors", error.ErrorMessage);
                    }

                    model.CountryOutput = CountryOutputModel;
                    model.GenderOutput = GenderOutputModel;

                    return View(model);
                }

                Account account = AssignAccountStudentExternalLoginProperties(model.Input);

                var user = new ApplicationUser
                {
                    UserName = model.Input.Email,
                    Email = model.Input.Email,
                    Account = account
                };

                var result = await UserManager.CreateAsync(user);
                if (result.Succeeded)
                {
                    result = AddUserToRole(user, UserRole.Student);

                    if (result.Succeeded)
                    {
                        result = await UserManager.AddLoginAsync(user.Id, info.Login);

                        if (result.Succeeded)
                        {
                            await SignInManager.SignInAsync(user, isPersistent: false, rememberBrowser: false);
                            return RedirectToUserRoleHomePage(UserRole.Student);
                        }
                    }
                }
                AddErrors(result);
            }

            model.CountryOutput = CountryOutputModel;
            model.GenderOutput = GenderOutputModel;
            return View(model);
        }

        [AllowAnonymous]
        public async Task<ActionResult> ExternalLoginTeacherConfirmation()
        {
            var loginInfo = await AuthenticationManager.GetExternalLoginInfoAsync();
            if (loginInfo == null)
            {
                return RedirectToAction("Login");
            }

            var input = new CreateAccountTeacherExternalLoginInputModel();

            if (loginInfo.Login.LoginProvider == "Google")
            {
                var externalIdentity = AuthenticationManager.GetExternalIdentityAsync(DefaultAuthenticationTypes.ExternalCookie);
                var emailClaim = externalIdentity.Result.Claims.FirstOrDefault(c => c.Type == ClaimTypes.Email);
                var lastNameClaim = externalIdentity.Result.Claims.FirstOrDefault(c => c.Type == ClaimTypes.Surname);
                var givenNameClaim = externalIdentity.Result.Claims.FirstOrDefault(c => c.Type == ClaimTypes.GivenName);

                input.Email = emailClaim.Value;
                input.FirstName = givenNameClaim.Value;
                input.Name = lastNameClaim.Value;
            }

            var viewModel = new ExternalLoginConfirmationTeacherViewModel()
            {
                Input = input,
                CountryOutput = CountryOutputModel,
                GenderOutput = GenderOutputModel
            };

            return View(viewModel);
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> ExternalLoginTeacherConfirmation(ExternalLoginConfirmationTeacherViewModel model)
        {
            if (User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Update");
            }

            if (ModelState.IsValid)
            {
                // Get the information about the user from the external login provider
                var info = await AuthenticationManager.GetExternalLoginInfoAsync();
                if (info == null)
                {
                    return View("ExternalLoginFailure");
                }

                var accountAppService = new AccountTeacherAppService();
                CreateAccountTeacherExternalLoginOutputModel output = accountAppService.CreateExternalLogin(model.Input);

                if (!output.Response.Success)
                {
                    foreach (var error in output.Response.Errors)
                    {
                        ModelState.AddModelError("ValidatorErrors", error.ErrorMessage);
                    }

                    model.CountryOutput = CountryOutputModel;
                    model.GenderOutput = GenderOutputModel;

                    return View(model);
                }

                Account account = AssignAccountTeacherExternalLoginProperties(model.Input);

                var user = new ApplicationUser
                {
                    UserName = model.Input.Email,
                    Email = model.Input.Email,
                    Account = account
                };

                var result = await UserManager.CreateAsync(user);
                if (result.Succeeded)
                {
                    result = AddUserToRole(user, UserRole.Teacher);

                    if (result.Succeeded)
                    {
                        result = await UserManager.AddLoginAsync(user.Id, info.Login);

                        if (result.Succeeded)
                        {
                            await SignInManager.SignInAsync(user, isPersistent: false, rememberBrowser: false);
                            return RedirectToUserRoleHomePage(UserRole.Teacher);
                        }
                    }
                }
                AddErrors(result);
            }

            model.CountryOutput = CountryOutputModel;
            model.GenderOutput = GenderOutputModel;
            return View(model);
        }

        //
        // POST: /Account/LogOff
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult LogOff()
        {
            AuthenticationManager.SignOut(DefaultAuthenticationTypes.ApplicationCookie);
            return RedirectToAction("Index", "Home");
        }

        //
        // GET: /Account/ExternalLoginFailure
        [AllowAnonymous]
        public ActionResult ExternalLoginFailure()
        {
            return View();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (_userManager != null)
                {
                    _userManager.Dispose();
                    _userManager = null;
                }

                if (_signInManager != null)
                {
                    _signInManager.Dispose();
                    _signInManager = null;
                }
            }

            base.Dispose(disposing);
        }




        #region PersonalUtilities

        private ActionResult RedirectToUserRoleHomePage(string returnUrl, string source)
        {
            if (!string.IsNullOrEmpty(returnUrl))
                return RedirectToLocal(returnUrl);

            return RedirectToUserRoleHomePage(GetUserRoleSignInManager(), source);
        }

        private Account AssignAccountStudentProperties(CreateAccountStudentInputModel input)
        {
            var accountStudent = new AccountStudent()
            {
                ACSBIRTHDAY = input.BirthDay,
                ACSFIRSTNAME = input.FirstName,
                ACSNAME = input.Name,
                GENCODE = new Guid(input.Gender),
                ACSLEVEL = input.Level,
                ACSUNIVERSITY = input.University,
                STDCODE = new Guid(input.Study)
            };

            var account = new Account
            {
                CTRCODE = new Guid(input.Country),
                ATPCODE = new Guid("09ee69af-a191-e811-821f-2c600c6934be"),
                ACCEMAIL = input.Email,
                ACCPASSWORD = string.Empty,
                ACCPHONECONTACT = string.Empty,
                ACCINSCRIPTIONDATE = DateTime.Now
            };

            account.AccountStudents.Add(accountStudent);

            return account;
        }

        private Account AssignAccountStudentExternalLoginProperties(CreateAccountStudentExternalLoginInputModel input)
        {
            var accountStudent = new AccountStudent()
            {
                ACSBIRTHDAY = input.BirthDay,
                ACSFIRSTNAME = input.FirstName,
                ACSNAME = input.Name,
                GENCODE = new Guid(input.Gender)
            };

            var account = new Account()
            {
                CTRCODE = new Guid(input.Country),
                ATPCODE = new Guid("09ee69af-a191-e811-821f-2c600c6934be"),
                ACCEMAIL = input.Email,
                ACCPASSWORD = string.Empty,
                ACCPHONECONTACT = string.Empty,
                ACCINSCRIPTIONDATE = DateTime.Now
            };

            account.AccountStudents.Add(accountStudent);

            return account;
        }

        private Account AssignAccountTeacherProperties(CreateAccountTeacherInputModel input)
        {
            var accountTeacher = new AccountTeacher()
            {
                ACTBIRTHDAY = input.BirthDay,
                ACTFIRSTNAME = input.FirstName,
                ACTNAME = input.Name,
                ACTTOWN = input.Town,
                ACTPOSTALCODE = input.PostalCode,
                ACTADDRESS = input.Address,
                GENCODE = new Guid(input.Gender)
            };

            var account = new Account()
            {
                CTRCODE = new Guid(input.Country),
                ATPCODE = new Guid("4650653E-E49A-E811-821F-2C600C6934BE"),
                ACCEMAIL = input.Email,
                ACCPASSWORD = string.Empty,
                ACCPHONECONTACT = input.PhoneNumber,
                ACCINSCRIPTIONDATE = DateTime.Now
            };

            account.AccountTeachers.Add(accountTeacher);

            return account;
        }

        private Account AssignAccountTeacherExternalLoginProperties(CreateAccountTeacherExternalLoginInputModel input)
        {
            var accountTeacher = new AccountTeacher()
            {
                ACTBIRTHDAY = input.BirthDay,
                ACTFIRSTNAME = input.FirstName,
                ACTNAME = input.Name,
                ACTTOWN = input.Town,
                ACTPOSTALCODE = input.PostalCode,
                ACTADDRESS = input.Address,
                GENCODE = new Guid(input.Gender)
            };

            var account = new Account()
            {
                CTRCODE = new Guid(input.Country),
                ATPCODE = new Guid("4650653E-E49A-E811-821F-2C600C6934BE"),
                ACCEMAIL = input.Email,
                ACCPASSWORD = string.Empty,
                ACCPHONECONTACT = input.PhoneNumber,
                ACCINSCRIPTIONDATE = DateTime.Now
            };

            account.AccountTeachers.Add(accountTeacher);

            return account;
        }

        private IdentityResult AddUserToRole(ApplicationUser user, UserRole role)
        {
            var RoleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(new ApplicationDbContext()));
            var roleToString = UserRoleUtilities.RoleToString(role);

            //Create Role Admin if it does not exist
            if (!RoleManager.RoleExists(roleToString))
            {
                RoleManager.Create(new IdentityRole(roleToString));
            }

            return UserManager.AddToRole(user.Id, roleToString);
        }

        private UserRole GetUserRoleSignInManager()
        {
            var id = SignInManager.AuthenticationManager.AuthenticationResponseGrant.Identity.GetUserId();

            if (UserManager.IsInRole(id, UserRoleUtilities.RoleToString(UserRole.Student)))
            {
                return UserRole.Student;
            }
            else if (UserManager.IsInRole(id, UserRoleUtilities.RoleToString(UserRole.Teacher)))
            {
                return UserRole.Teacher;
            }
            else if (UserManager.IsInRole(id, UserRoleUtilities.RoleToString(UserRole.Admin)))
            {
                return UserRole.Admin;
            }
            else
            {
                return UserRole.Student;
            }
        }


        private UpdateAccountStudentInputModel GetUpdateStudentInputModel(Account account)
        {
            var details = account.AccountStudents.FirstOrDefault();

            if (details == null)
            {
                throw new InvalidOperationException();
            }

            var input = new UpdateAccountStudentInputModel
            {
                AccountId = account.Id.ToString(),
                Name = details.ACSNAME,
                FirstName = details.ACSFIRSTNAME,
                Country = account.CTRCODE.ToString(),
                Gender = details.GENCODE.ToString(),
                BirthDay = details.ACSBIRTHDAY,
                PhoneNumber = account.ACCPHONECONTACT,
                Picture = account.ACCPICTURE,
                Level = details.ACSLEVEL,
                University = details.ACSUNIVERSITY,
                Study = details.STDCODE.ToString()
                
            };

            return input;
        }

        private UpdateAccountTeacherInputModel GetUpdateTeacherInputModel(Account account)
        {
            var details = account.AccountTeachers.FirstOrDefault();

            if (details == null)
            {
                throw new InvalidOperationException();
            }

            var input = new UpdateAccountTeacherInputModel
            {
                AccountId = account.Id.ToString(),
                Name = details.ACTNAME,
                FirstName = details.ACTFIRSTNAME,
                Country = account.CTRCODE.ToString(),
                Gender = details.GENCODE.ToString(),
                BirthDay = details.ACTBIRTHDAY,
                PhoneNumber = account.ACCPHONECONTACT,
                Address = details.ACTADDRESS,
                PostalCode = details.ACTPOSTALCODE,
                Town = details.ACTTOWN,
                Picture = account.ACCPICTURE
            };

            return input;
        }

        private bool HasPassword()
        {
            var user = UserManager.FindById(User.Identity.GetUserId());
            if (user != null)
            {
                return user.PasswordHash != null;
            }
            return false;
        }

        #endregion

        #region Helpers
        // Used for XSRF protection when adding external logins
        private const string XsrfKey = "XsrfId";

        private IAuthenticationManager AuthenticationManager
        {
            get
            {
                return HttpContext.GetOwinContext().Authentication;
            }
        }

        private void AddErrors(IdentityResult result)
        {
            foreach (var error in result.Errors)
            {
                ModelState.AddModelError("", error);
            }
        }

        private ActionResult RedirectToLocal(string returnUrl)
        {
            if (Url.IsLocalUrl(returnUrl))
            {
                return Redirect(returnUrl);
            }
            return RedirectToAction("Index", "Home");
        }

        internal class ChallengeResult : HttpUnauthorizedResult
        {
            public ChallengeResult(string provider, string redirectUri)
                : this(provider, redirectUri, null)
            {
            }

            public ChallengeResult(string provider, string redirectUri, string userId)
            {
                LoginProvider = provider;
                RedirectUri = redirectUri;
                UserId = userId;
            }

            public string LoginProvider { get; set; }
            public string RedirectUri { get; set; }
            public string UserId { get; set; }

            public override void ExecuteResult(ControllerContext context)
            {
                var properties = new AuthenticationProperties { RedirectUri = RedirectUri };
                if (UserId != null)
                {
                    properties.Dictionary[XsrfKey] = UserId;
                }
                context.HttpContext.GetOwinContext().Authentication.Challenge(properties, LoginProvider);
            }
        }
        #endregion
    }
}