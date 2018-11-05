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

namespace ASTEK.Architecture.BusinessService.Entity.AccountStudent
{
    public class AccountStudentBusinessService: EntityServiceBase<Domain.Entity.AccountStudent.AccountStudent>, IAccountStudentBusinessService
    {
        private readonly EFAccountStudentRepository _repository;

        public AccountStudentBusinessService()
        {
            var context = new EFDbContext();
            _repository = new EFAccountStudentRepository(context);
        }

        //Géré par Identity
        public CreateAccountStudentResponse Create(CreateAccountStudentRequest request)
        {
            var response = new CreateAccountStudentResponse();
            List<ValidationFailure> errors = new List<ValidationFailure>();

            var account = new Domain.Entity.Account.Account
            {
                CTRCODE = request.Contry,
                ACCEMAIL = request.Email,
                ACCPASSWORD = request.Password,
                ACCINSCRIPTIONDATE = DateTime.Now,
            };

            var accBusinessService = new Account.AccountBusinessService();
            errors.AddRange(accBusinessService.GetErrors(account, ValidationType.Add));

            var accountStudent = AssignAvailablePropertiesToDomain(request);
            errors.AddRange(GetErrors(accountStudent, ValidationType.Add));

            if (errors.Any())
            {
                response.Success = false;
                response.Errors = errors;

                return response;
            }

            response.Success = true;

            return response;
        }

        public override List<ValidationFailure> GetErrors(Domain.Entity.AccountStudent.AccountStudent entity, ValidationType validationType)
        {
            return new AccountStudentValidator(validationType).Validate(entity).Errors.ToList();
        }

        public UpdateAccountStudentResponse Update(UpdateAccountStudentRequest request)
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

                var accountStudent = new Domain.Entity.AccountStudent.AccountStudent
                {
                    ACCID = request.AccountId,
                    ACSNAME = request.Name,
                    ACSFIRSTNAME = request.FirstName,
                    ACSBIRTHDAY = request.BirthDay,
                    GENCODE = request.Gender,
                    Account = account,
                    ACSLEVEL = request.Level,
                    ACSUNIVERSITY = request.University,
                    STDCODE = request.StudyCode
                };

                errors.AddRange(GetErrors(accountStudent, ValidationType.Update));

                if (errors.Any())
                {
                    return new UpdateAccountStudentResponse
                    {
                        Success = false,
                        ValidatorErrors = errors                 
                    };
                }

                var updated = _repository.UpdateInformations(accountStudent);

                return new UpdateAccountStudentResponse
                {
                    Success = true,
                    Updated = updated
                };
            }
            catch(Exception ex)
            {
                return new UpdateAccountStudentResponse
                {
                    Success = false,
                    Exception = ex
                };
            }
        }

        private Domain.Entity.AccountStudent.AccountStudent AssignAvailablePropertiesToDomain(CreateAccountStudentRequest request)
        {
            var accountStudent = new Domain.Entity.AccountStudent.AccountStudent
            {
                ACSNAME = request.Name,
                ACSFIRSTNAME = request.FirstName,
                ACSBIRTHDAY = request.BirthDay,
                GENCODE = request.Gender,
                ACSLEVEL = request.Level,
                ACSUNIVERSITY = request.University
            };

            return accountStudent;
        }
    }
}
