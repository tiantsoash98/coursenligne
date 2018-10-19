using ASTEK.Architecture.BusinessService.Rule;
using ASTEK.Architecture.Infrastructure.Validator.Abstract;
using ASTEK.Architecture.Repository.Concrete;

namespace ASTEK.Architecture.BusinessService.Validator
{
    public class SignUpAccountValidator : ValidatorBusinessBase
    {
        private readonly EFAccountRepository _accountRepository;
        private readonly Domain.Entity.Account.Account Account;

        public SignUpAccountValidator(EFAccountRepository accountRepository, Domain.Entity.Account.Account account)
        {
            _accountRepository = accountRepository;
            Account = account;
        }

        public override void AddRules()
        {
            AddRule(new SingleEmailRule(_accountRepository, Account.ACCEMAIL));
        }
    }
}
