using System;
using System.Linq;
using ASTEK.Architecture.Domain.Entity.AccountStudent;
using ASTEK.Architecture.Infrastructure.Exception;
using ASTEK.Architecture.Infrastructure.UnitOfWork;
using System.Data.Entity;

namespace ASTEK.Architecture.Repository.Concrete
{
    public class EFAccountStudentRepository : EFRepository<AccountStudent, Guid>, IAccountStudentRepository
    {
        public EFAccountStudentRepository(IUnitOfWork uow)
            : base(uow)
        {
        }

        public AccountStudent UpdateInformations(AccountStudent entity)
        {
            Context.AccountStudents.Include(s => s.Account).ToList();

            var student = Context.AccountStudents.FirstOrDefault(s => s.ACCID.Equals(entity.ACCID));

            if (student == null)
            {
                throw new EntityNotFoundException(Infrastructure.InfrastructureStrings.NotFound_Account);
            }

            student.ACSBIRTHDAY = entity.ACSBIRTHDAY;
            student.ACSFIRSTNAME = entity.ACSFIRSTNAME;
            student.ACSNAME = entity.ACSNAME;
            student.GENCODE = entity.GENCODE;

            student.Account.CTRCODE = entity.Account.CTRCODE;
            student.Account.ACCPHONECONTACT = entity.Account.ACCPHONECONTACT;

            Save(student);

            return student;
        }
    }
}