using System;
using ASTEK.Architecture.Infrastructure.Domain;
using ASTEK.Architecture.Domain.Entity;

namespace ASTEK.Architecture.Domain.Entity.Account
{
    public interface IAccountRepository : IRepository<Account, Guid>
    {
        Account FindByEmail(string email);
        Account GetAllInformations(Guid accountId);
    }
}