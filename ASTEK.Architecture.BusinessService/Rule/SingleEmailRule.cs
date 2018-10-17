using ASTEK.Architecture.Infrastructure.Specification;
using ASTEK.Architecture.Infrastructure.Validator.Abstract;
using ASTEK.Architecture.Repository.Concrete;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace ASTEK.Architecture.BusinessService.Rule
{
    public class SingleEmailRule : IRule
    {
        private readonly EFAccountRepository _accountRepository;
        private readonly string Email;

        public SingleEmailRule(EFAccountRepository repository, string email)
        {
            _accountRepository = repository;
            Email = email;
        }

        public ValidationFailure Validate()
        {
            ValidationFailure result = null;

            Expression<Func<Domain.Entity.Account.Account, bool>> findByEmail = e => e.ACCEMAIL.Equals(Email);
            Specification<Domain.Entity.Account.Account> spec = new Specification<Domain.Entity.Account.Account>(findByEmail);
            IEnumerable<Domain.Entity.Account.Account> resultFind = _accountRepository.FindBy(spec);

            if(resultFind.Any())
            {
                result = new ValidationFailure("Email", string.Format(BusinessStrings.BusinessValidation_UniqueEmail, Email));
            }

            return result;
        }
    }
}
