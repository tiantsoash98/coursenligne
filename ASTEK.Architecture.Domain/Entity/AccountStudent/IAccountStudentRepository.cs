using ASTEK.Architecture.Infrastructure.Domain;
using System;

namespace ASTEK.Architecture.Domain.Entity.AccountStudent
{
    public interface IAccountStudentRepository : IRepository<AccountStudent, Guid>
    {
        AccountStudent UpdateInformations(AccountStudent entity);
    }
}
