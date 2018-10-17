using ASTEK.Architecture.BusinessService.Entity.Account;

namespace ASTEK.Architecture.BusinessService.Account
{
    public interface IAccountBusinessService
    {
        CreateAccountResponse Create(CreateAccountRequest request);
        UpdateAccountResponse Update(UpdateAccountRequest request);
        DeleteAccountResponse Delete(DeleteAccountRequest request);
        GetAccountResponse Get(GetAccountRequest request);
        GetAccountByEmailResponse GetByEmail(GetAccountByEmailRequest request);
        GetAllAccountResponse GetAll(GetAllAccountRequest request);
        GetAllInformationsAccountResponse GetAllInformations(GetAllInformationsAccountRequest request);
        LoginAccountResponse Login(LoginAccountRequest request);
        UpdateAccountImageResponse UpdateImage(UpdateAccountImageRequest request);
        UploadAccountImageResponse UploadImage(UploadAccountImageRequest request);
    }
}
