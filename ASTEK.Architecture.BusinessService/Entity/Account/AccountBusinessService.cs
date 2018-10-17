using ASTEK.Architecture.BusinessService.Abstract;
using ASTEK.Architecture.BusinessService.Account;
using ASTEK.Architecture.BusinessService.Validator;
using ASTEK.Architecture.Domain.Validator;
using ASTEK.Architecture.Infrastructure.Domain;
using ASTEK.Architecture.Infrastructure.Exception;
using ASTEK.Architecture.Infrastructure.Utility;
using ASTEK.Architecture.Repository;
using ASTEK.Architecture.Repository.Concrete;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.IO;
using System.Linq;

namespace ASTEK.Architecture.BusinessService.Entity.Account
{
    public class AccountBusinessService : EntityServiceBase<Domain.Entity.Account.Account>, IAccountBusinessService
    {
        private readonly EFAccountRepository _repository;

        public AccountBusinessService()
        {
            var context = new EFDbContext();
            _repository = new EFAccountRepository(context);
        }

        public CreateAccountResponse Create(CreateAccountRequest request)
        {
            throw new NotImplementedException();
        }


        public DeleteAccountResponse Delete(DeleteAccountRequest request)
        {
            throw new NotImplementedException();
        }

        public GetAccountResponse Get(GetAccountRequest request)
        {
            var account = _repository.FindBy(request.Id);

            if (account == null)
            {
                return new GetAccountResponse()
                {
                    Success = false,
                    Exception = new EntityNotFoundException(Infrastructure.InfrastructureStrings.NotFound_Lesson)
                };
            }

            return new GetAccountResponse()
            {
                Success = true,
                Account = account
            };
        }

        public GetAllAccountResponse GetAll(GetAllAccountRequest request)
        {
            throw new NotImplementedException();
        }

        public LoginAccountResponse Login(LoginAccountRequest request)
        {
            var loginResponse = new LoginAccountResponse();

            try
            {
                var account = new Domain.Entity.Account.Account()
                {
                    ACCEMAIL = request.Email
                };

                ThrowExceptionIfIsInvalid(account, ValidationType.Get);

                loginResponse.Success = true;
            }
            catch (Exception ex)
            {
                loginResponse.Success = false;
                loginResponse.Exception = ex;
            }

            return loginResponse;
        }

        public UpdateAccountResponse Update(UpdateAccountRequest request)
        {
            throw new NotImplementedException();
        }

        public override List<ValidationFailure> GetErrors(Domain.Entity.Account.Account entity, ValidationType validationType)
        {
            return new AccountValidator(validationType).Validate(entity).Errors.ToList();
        }

        public GetAccountByEmailResponse GetByEmail(GetAccountByEmailRequest request)
        {
            var account = _repository.FindByEmail(request.Email);

            if (account == null)
            {
                return new GetAccountByEmailResponse()
                {
                    Success = false,
                    Exception = new EntityNotFoundException(Infrastructure.InfrastructureStrings.NotFound_Lesson)
                };
            }

            return new GetAccountByEmailResponse()
            {
                Success = true,
                Account = account
            };
        }

        public GetAllInformationsAccountResponse GetAllInformations(GetAllInformationsAccountRequest request)
        {
            try
            {
                var account = _repository.GetAllInformations(request.AccountId);

                if (account == null)
                {
                    throw new EntityNotFoundException(Infrastructure.InfrastructureStrings.NotFound_Lesson);
                }

                return new GetAllInformationsAccountResponse
                {
                    Success = true,
                    Account = account
                };
            }
            catch (Exception ex)
            {
                return new GetAllInformationsAccountResponse
                {
                    Success = false,
                    Exception = ex
                };
            }
        }

        public UpdateAccountImageResponse UpdateImage(UpdateAccountImageRequest request)
        {
            try
            {
                var account = _repository.FindBy(request.AccountId);

                if (account == null)
                {
                    throw new EntityNotFoundException(Infrastructure.InfrastructureStrings.NotFound_Account);
                }

                account.ACCPICTURE = request.ImageName;

                _repository.Save(account);

                return new UpdateAccountImageResponse
                {
                    Success = true
                };
            }
            catch (Exception e)
            {
                return new UpdateAccountImageResponse
                {
                    Success = false,
                    Exception = e
                };
            }
        }

        public UploadAccountImageResponse UploadImage(UploadAccountImageRequest request)
        {
            try
            {
                string currentfileExtension = Path.GetExtension(request.FileName);

                int maxImageLength = Convert.ToInt32(ConfigurationManager.AppSettings.Get("MaxImageLength"));

                var validator = new UploadImageValidator(request.Stream, currentfileExtension, request.ContentLength, maxImageLength);
                ValidationResult result = validator.Validate();

                if (result.Errors.Any())
                {
                    return new UploadAccountImageResponse
                    {
                        Success = false,
                        ValidationFailures = result.Errors.ToList()
                    };
                }

                string pathToSave = Path.Combine(ConfigurationManager.AppSettings.Get("AbsoluteFileUrl"),
                                                        ConfigurationManager.AppSettings.Get("ImageFolder"),
                                                            ConfigurationManager.AppSettings.Get("AccountFolder"));

                string thumbnailPath = Path.Combine(ConfigurationManager.AppSettings.Get("AbsoluteFileUrl"),
                                                        ConfigurationManager.AppSettings.Get("ImageFolder"),
                                                            ConfigurationManager.AppSettings.Get("ThumbnailFolder"),
                                                                ConfigurationManager.AppSettings.Get("AccountFolder"));


                var img = Image.FromStream(request.Stream);
                var resizedImg = ImageUtilities.ResizeImageByHeight(img, Convert.ToInt32(ConfigurationManager.AppSettings.Get("AccountImageHeight")));
                var thumbnail = ImageUtilities.ResizeImageByHeight(img, Convert.ToInt32(ConfigurationManager.AppSettings.Get("AccountThumbnailImageHeight")));

                string fileNameToSave = string.Concat(request.AccountId.ToString(), ConfigurationManager.AppSettings.Get("ImageExtension"));
                string savedFileName = Path.Combine(pathToSave, fileNameToSave);
                string savedThumbnailFileName = Path.Combine(thumbnailPath, fileNameToSave);

                resizedImg.Save(savedFileName);
                thumbnail.Save(savedThumbnailFileName);

                thumbnail.Dispose();
                resizedImg.Dispose();
                img.Dispose();

                var updateRequest = new UpdateAccountImageRequest
                {
                    AccountId = request.AccountId,
                    ImageName = fileNameToSave
                };



                var updateResponse = UpdateImage(updateRequest);

                if (!updateResponse.Success)
                {
                    throw updateResponse.Exception;
                }

                return new UploadAccountImageResponse
                {
                    Success = true,
                    FileName = savedFileName
                };
            }
            catch (Exception e)
            {
                return new UploadAccountImageResponse
                {
                    Success = false,
                    Exception = e
                };
            }
        }
    }
}
