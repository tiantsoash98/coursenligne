using ASTEK.Architecture.Infrastructure.Domain;
using System;
using System.Collections.Generic;

namespace ASTEK.Architecture.Domain.Entity.Gender
{
    public interface IGenderRepository: IRepository<Gender, Guid>
    {
        IEnumerable<Gender> FindAll(string culture);
    }
}
