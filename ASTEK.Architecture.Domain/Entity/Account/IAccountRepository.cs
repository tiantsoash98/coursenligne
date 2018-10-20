using ASTEK.Architecture.Infrastructure.Domain;
using System;

namespace ASTEK.Architecture.Domain.Entity.Account
{
    public interface IAccountRepository : IRepository<Account, Guid>
    {
        Account FindByEmail(string email);
        Account GetAllInformations(Guid accountId);
    }
}