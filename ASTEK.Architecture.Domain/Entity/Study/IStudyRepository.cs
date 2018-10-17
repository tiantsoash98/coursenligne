using ASTEK.Architecture.Infrastructure.Domain;
using System;
using System.Collections.Generic;

namespace ASTEK.Architecture.Domain.Entity.Study
{
    public interface IStudyRepository: IRepository<Study, Guid>
    {
        IEnumerable<Study> FindAll(string culture);
        string GetPicture(Guid studyId);
    }
}
