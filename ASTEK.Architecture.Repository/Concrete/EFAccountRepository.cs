using System;
using System.Data.Entity;
using System.Linq;
using ASTEK.Architecture.Domain.Entity.Account;
using ASTEK.Architecture.Infrastructure.Domain;
using ASTEK.Architecture.Infrastructure.Exception;
using ASTEK.Architecture.Infrastructure.UnitOfWork;

namespace ASTEK.Architecture.Repository.Concrete
{
    public class EFAccountRepository : EFRepository<Account, Guid>, IAccountRepository
    {
        public EFAccountRepository(IUnitOfWork uow)
            : base(uow)
        {
        }

        public Account FindByEmail(string email)
        {
            return Context.Accounts
                            .FirstOrDefault(account => account.ACCEMAIL.Equals(email));
        }

        public Account GetAllInformations(Guid accountId)
        {
            Context.Accounts.Include(account => account.AccountStudents).ToList();
            Context.Accounts.Include(account => account.AccountTeachers).ToList();

            return Context.Accounts.FirstOrDefault(account => account.Id.Equals(accountId));
        }

        public Account UpdateInformations(Guid accountId, string name, string firstName, DateTime birthDay, Guid gender, UserRole role)
        {
            if(role == UserRole.Student)
            {
                var student = Context.AccountStudents.FirstOrDefault(s => s.ACCID.Equals(accountId));

                if(student is null)
                {
                    throw new EntityNotFoundException(Infrastructure.InfrastructureStrings.NotFound_Account);
                }

                student.ACSBIRTHDAY = birthDay;
                student.ACSFIRSTNAME = firstName;
                student.ACSNAME = name;
                student.GENCODE = gender;

                Context.SaveChanges();
                return student.Account;
            }

            else
            {
                var teacher = Context.AccountTeachers.FirstOrDefault(s => s.ACCID.Equals(accountId));

                if (teacher is null)
                {
                    throw new EntityNotFoundException(Infrastructure.InfrastructureStrings.NotFound_Account);
                }

                teacher.ACTBIRTHDAY = birthDay;
                teacher.ACTFIRSTNAME = firstName;
                teacher.ACTNAME = name;
                teacher.GENCODE = gender;

                Context.SaveChanges();
                return teacher.Account;
            }
        }
    }
}