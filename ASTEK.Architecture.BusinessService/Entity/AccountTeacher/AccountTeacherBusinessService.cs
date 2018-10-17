using ASTEK.Architecture.BusinessService.Abstract;
using ASTEK.Architecture.BusinessService.Interface;
using ASTEK.Architecture.Domain.Validator;
using ASTEK.Architecture.Infrastructure.Domain;
using ASTEK.Architecture.Repository;
using ASTEK.Architecture.Repository.Concrete;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ASTEK.Architecture.BusinessService.Entity.AccountTeacher
{
    public class AccountTeacherBusinessService : EntityServiceBase<Domain.Entity.AccountTeacher.AccountTeacher>, IAccountTeacherBusinessService
    {
        private readonly EFAccountTeacherRepository _repository;

        public AccountTeacherBusinessService()
        {
            var context = new EFDbContext();
            _repository = new EFAccountTeacherRepository(context);
        }

        public CreateAccountTeacherResponse Create(CreateAccountTeacherRequest request)
        {
            var response = new CreateAccountTeacherResponse();
            List<ValidationFailure> errors = new List<ValidationFailure>();

            var account = new Domain.Entity.Account.Account()
            {
                CTRCODE = request.Contry,
                ACCPHONECONTACT = request.PhoneNumber,
                ACCEMAIL = request.Email,
                ACCPASSWORD = request.Password,
                ACCINSCRIPTIONDATE = DateTime.Now,
            };

            var accBusinessService = new Account.AccountBusinessService();
            errors.AddRange(accBusinessService.GetErrors(account, ValidationType.Add));

            var accountTeacher = AssignAvailablePropertiesToDomain(request);
            errors.AddRange(GetErrors(accountTeacher, ValidationType.Add));

            if (errors.Any())
            {
                response.Success = false;
                response.Errors = errors;

                return response;
            }

            response.Success = true;

            return response;
        }

        public override List<ValidationFailure> GetErrors(Domain.Entity.AccountTeacher.AccountTeacher entity, ValidationType validationType)
        {
            return new AccountTeacherValidator(validationType).Validate(entity).Errors.ToList();
        }

        public UpdateAccountTeacherResponse Update(UpdateAccountTeacherRequest request)
        {
            try
            {
                List<ValidationFailure> errors = new List<ValidationFailure>();

                var account = new Domain.Entity.Account.Account()
                {
                    Id = request.AccountId,
                    CTRCODE = request.Country,
                    ACCPHONECONTACT = request.Phone
                };

                var accBusinessService = new Account.AccountBusinessService();
                errors.AddRange(accBusinessService.GetErrors(account, ValidationType.Update));

                var accountTeacher = new Domain.Entity.AccountTeacher.AccountTeacher()
                {
                    ACCID = request.AccountId,
                    ACTNAME = request.Name,
                    ACTFIRSTNAME = request.FirstName,
                    ACTBIRTHDAY = request.BirthDay,
                    GENCODE = request.Gender,
                    ACTADDRESS = request.Address,
                    ACTPOSTALCODE = request.PostalCode,
                    ACTTOWN = request.Town,
                    Account = account
                };

                errors.AddRange(GetErrors(accountTeacher, ValidationType.Update));

                if (errors.Any())
                {
                    return new UpdateAccountTeacherResponse
                    {
                        Success = false,
                        ValidatorErrors = errors
                    };
                }

                var updated = _repository.UpdateInformations(accountTeacher);

                return new UpdateAccountTeacherResponse
                {
                    Success = true,
                    Updated = updated
                };
            }
            catch (Exception ex)
            {
                return new UpdateAccountTeacherResponse
                {
                    Success = false,
                    Exception = ex
                };
            }
        }

        private Domain.Entity.AccountTeacher.AccountTeacher AssignAvailablePropertiesToDomain(CreateAccountTeacherRequest request)
        {
            var accountTeacher = new Domain.Entity.AccountTeacher.AccountTeacher()
            {
                ACTNAME = request.Name,
                ACTFIRSTNAME = request.FirstName,
                ACTBIRTHDAY = request.BirthDay,
                GENCODE = request.Gender,
                ACTTOWN = request.Town,
                ACTPOSTALCODE = request.PostalCode,
                ACTADDRESS = request.Address
            };

            return accountTeacher;
        }
    }
}
