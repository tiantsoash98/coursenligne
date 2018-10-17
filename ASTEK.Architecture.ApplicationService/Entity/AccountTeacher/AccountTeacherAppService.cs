using ASTEK.Architecture.BusinessService.Entity.AccountTeacher;
using ASTEK.Architecture.BusinessService.Interface;
using ASTEK.Architecture.Infrastructure.Utility;

namespace ASTEK.Architecture.ApplicationService.Entity.AccountTeacher
{
    public class AccountTeacherAppService
    {
        private readonly IAccountTeacherBusinessService _service;

        public AccountTeacherAppService()
        {
            _service = new AccountTeacherBusinessService();
        }

        public CreateAccountTeacherOutputModel Create(CreateAccountTeacherInputModel input)
        {
            var request = new CreateAccountTeacherRequest
            {
                Name = input.Name,
                FirstName = input.FirstName,
                BirthDay = input.BirthDay,
                Gender = GuidUtilities.TryParse(input.Gender),
                Contry = GuidUtilities.TryParse(input.Country),
                Town = input.Town,
                Address = input.Address,
                PostalCode = input.PostalCode,
                Email = input.Email,
                Password = input.Password,
                ConfirmPassword = input.ConfirmPassword
            };

            var response = _service.Create(request);

            var output = new CreateAccountTeacherOutputModel
            {
                Response = response
            };

            return output;
        }

        public CreateAccountTeacherExternalLoginOutputModel CreateExternalLogin(CreateAccountTeacherExternalLoginInputModel input)
        {
            var request = new CreateAccountTeacherRequest
            {
                Name = input.Name,
                FirstName = input.FirstName,
                BirthDay = input.BirthDay,
                Gender = GuidUtilities.TryParse(input.Gender),
                Contry = GuidUtilities.TryParse(input.Country),
                Town = input.Town,
                Address = input.Address,
                PostalCode = input.PostalCode,
                Email = input.Email,
            };

            var response = _service.Create(request);

            var output = new CreateAccountTeacherExternalLoginOutputModel
            {
                Response = response
            };

            return output;
        }

        public UpdateAccountTeacherOutputModel Update(UpdateAccountTeacherInputModel input)
        {
            var request = new UpdateAccountTeacherRequest
            {
                AccountId = GuidUtilities.TryParse(input.AccountId),
                Name = input.Name,
                FirstName = input.FirstName,
                BirthDay = input.BirthDay,
                Gender = GuidUtilities.TryParse(input.Gender),
                Country = GuidUtilities.TryParse(input.Country),
                Phone = input.PhoneNumber,
                Address = input.Address,
                PostalCode = input.PostalCode,
                Town = input.Town
            };

            UpdateAccountTeacherResponse response = _service.Update(request);

            return new UpdateAccountTeacherOutputModel() { Response = response };
        }
    }
}
