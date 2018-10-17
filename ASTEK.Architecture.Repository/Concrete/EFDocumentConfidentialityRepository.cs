using ASTEK.Architecture.Infrastructure.UnitOfWork;
using System;

namespace ASTEK.Architecture.Repository.Concrete
{
    public class EFDocumentConfidentialityRepository : EFRepository<Domain.Entity.DocumentConfidentiality.DocumentConfidentiality, Guid>, Domain.Entity.DocumentConfidentiality.IDocumentConfidentialityRepository
    {
        public EFDocumentConfidentialityRepository(IUnitOfWork uow)
            : base(uow)
        {
        }
    }
}
