using ASTEK.Architecture.Domain.Entity.Culture;
using ASTEK.Architecture.Infrastructure.UnitOfWork;
using System;

namespace ASTEK.Architecture.Repository.Concrete
{
    public class EFCultureRepository : EFRepository<Culture, Guid>, ICultureRepository
    {
        public EFCultureRepository(IUnitOfWork uow)
            : base(uow)
        {
        }
    }
}
