using System;
using ASTEK.Architecture.Infrastructure.UnitOfWork;

namespace ASTEK.Architecture.Repository.Concrete
{
    public class EFCountryRepository : EFRepository<Domain.Entity.Country.Country, Guid>, Domain.Entity.Country.ICountryRepository
    {
        public EFCountryRepository(IUnitOfWork uow)
            : base(uow)
        {
        }
    }
}