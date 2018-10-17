using ASTEK.Architecture.Infrastructure.Domain;
using System;

namespace ASTEK.Architecture.Domain.Entity.DocumentState
{
    public interface IDocumentStateRepository: IRepository<DocumentState, Guid>
    {
    }
}
