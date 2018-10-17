using System;
using System.Collections.Generic;
using System.Linq;
using ASTEK.Architecture.Domain.Entity.AccountTeacher;
using ASTEK.Architecture.Infrastructure.Exception;
using ASTEK.Architecture.Infrastructure.UnitOfWork;
using System.Data.Entity;

namespace ASTEK.Architecture.Repository.Concrete
{
    public class EFAccountTeacherRepository : EFRepository<AccountTeacher, Guid>, IAccountTeacherRepository
    {
        public EFAccountTeacherRepository(IUnitOfWork uow)
            : base(uow)
        {
        }

        public AccountTeacher UpdateInformations(AccountTeacher entity)
        {
            Context.AccountTeachers.Include(s => s.Account).ToList();

            var teacher = Context.AccountTeachers.FirstOrDefault(s => s.ACCID.Equals(entity.ACCID));

            if (teacher is null)
            {
                throw new EntityNotFoundException(Infrastructure.InfrastructureStrings.NotFound_Account);
            }

            teacher.ACTBIRTHDAY = entity.ACTBIRTHDAY;
            teacher.ACTFIRSTNAME = entity.ACTFIRSTNAME;
            teacher.ACTNAME = entity.ACTNAME;
            teacher.GENCODE = entity.GENCODE;
            teacher.ACTADDRESS = entity.ACTADDRESS;
            teacher.ACTPOSTALCODE = entity.ACTPOSTALCODE;
            teacher.ACTTOWN = entity.ACTTOWN;

            teacher.Account.CTRCODE = entity.Account.CTRCODE;
            teacher.Account.ACCPHONECONTACT = entity.Account.ACCPHONECONTACT;

            Save(teacher);

            return teacher;
        }
    }
}