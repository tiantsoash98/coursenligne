using ASTEK.Architecture.Infrastructure.Domain;
using System;

namespace ASTEK.Architecture.Domain.Entity.Culture
{
    public interface ICultureRepository: IRepository<Culture, Guid>
    {
    }
}
