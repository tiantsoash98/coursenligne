using ASTEK.Architecture.BusinessService.Account;
using ASTEK.Architecture.BusinessService.Entity.Account;
using ASTEK.Architecture.Infrastructure.Utility;

namespace ASTEK.Architecture.ApplicationService.Entity.Account
{
    public class AccountAppService
    {
        private readonly IAccountBusinessService _service;

        public AccountAppService()
        {
            _service = new AccountBusinessService();
        }

        public LoginAccountOutputModel Login(LoginAccountInputModel input)
        {
            var request = new LoginAccountRequest()
            {
                Email = input.Email
            };

            LoginAccountResponse response = _service.Login(request);

            var output = new LoginAccountOutputModel(){ Response = response };

            return output;
        }

        public GetAccountByEmailOutputModel GetByEmail(GetAccountByEmailInputModel input)
        {
            var request = new GetAccountByEmailRequest()
            {
                Email = input.Email
            };

            GetAccountByEmailResponse response = _service.GetByEmail(request);

            var output = new GetAccountByEmailOutputModel() { Response = response };

            return output;
        }

        public GetAllInformationsAccountOutputModel GetAllInformations(GetAllInformationsAccountInputModel input)
        {
            var request = new GetAllInformationsAccountRequest()
            {
                AccountId = GuidUtilities.TryParse(input.AccountId)
            };

            GetAllInformationsAccountResponse response = _service.GetAllInformations(request);

            return new GetAllInformationsAccountOutputModel() { Response = response };
        }

        public UploadAccountImageOutputModel UploadImage(UploadAccountImageInputModel input)
        {
            var request = new UploadAccountImageRequest
            {
                AccountId = GuidUtilities.TryParse(input.Account),
                ContentLength = input.ContentLength,
                FileName = input.FileName,
                ContentType = input.ContentType,
                Stream = input.Stream
            };

            UploadAccountImageResponse response = _service.UploadImage(request);

            return new UploadAccountImageOutputModel { Response = response };
        }
    }
}
