using ASTEK.Architecture.BusinessService.Entity.AccountStudent;
using ASTEK.Architecture.BusinessService.Interface;
using ASTEK.Architecture.Infrastructure.Utility;

namespace ASTEK.Architecture.ApplicationService.Entity.AccountStudent
{
    public class AccountStudentAppService
    {
        private readonly IAccountStudentBusinessService _service;

        public AccountStudentAppService()
        {
            _service = new AccountStudentBusinessService();
        }

        public CreateAccountStudentOutputModel Create(CreateAccountStudentInputModel input)
        {
            var request = new CreateAccountStudentRequest
            {
                Name = input.Name,
                FirstName = input.FirstName,
                BirthDay = input.BirthDay,
                Gender = GuidUtilities.TryParse(input.Gender),
                Contry = GuidUtilities.TryParse(input.Country),
                Email = input.Email,
                Password = input.Password,
                ConfirmPassword = input.ConfirmPassword,
                IsExternalLogin = false,
                Level = input.Level
            };

            var response = _service.Create(request);

            return new CreateAccountStudentOutputModel
            {
                Response = response
            };
        }

        public CreateAccountStudentExternalLoginOutputModel CreateExternalLogin(CreateAccountStudentExternalLoginInputModel input)
        {
            var request = new CreateAccountStudentRequest
            {
                Name = input.Name,
                FirstName = input.FirstName,
                BirthDay = input.BirthDay,
                Gender = GuidUtilities.TryParse(input.Gender),
                Contry = GuidUtilities.TryParse(input.Country),
                Email = input.Email,
                IsExternalLogin = true
            };

            var response = _service.Create(request);

            return new CreateAccountStudentExternalLoginOutputModel
            {
                Response = response
            };
        }

        public UpdateAccountStudentOutputModel Update(UpdateAccountStudentInputModel input)
        {
            var request = new UpdateAccountStudentRequest
            {
                AccountId = GuidUtilities.TryParse(input.AccountId),
                Name = input.Name,
                FirstName = input.FirstName,
                BirthDay = input.BirthDay,
                Gender = GuidUtilities.TryParse(input.Gender),
                Country = GuidUtilities.TryParse(input.Country),
                Phone = input.PhoneNumber,
                University = input.University,
                Level = input.Level
            };

            UpdateAccountStudentResponse response = _service.Update(request);

            return new UpdateAccountStudentOutputModel() { Response = response };
        }
    }
}
