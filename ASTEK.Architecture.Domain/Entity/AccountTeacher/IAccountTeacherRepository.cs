using ASTEK.Architecture.Infrastructure.Domain;
using System;

namespace ASTEK.Architecture.Domain.Entity.AccountTeacher
{
    public interface IAccountTeacherRepository: IRepository<AccountTeacher, Guid>
    {
        AccountTeacher UpdateInformations(AccountTeacher entity);
    }
}
