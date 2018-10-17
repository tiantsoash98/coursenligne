using ASTEK.Architecture.Domain.Entity.Study;
using ASTEK.Architecture.Infrastructure.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace ASTEK.Architecture.Repository.Concrete
{
    public class EFStudyRepository: EFRepository<Study, Guid>, IStudyRepository
    {
        public EFStudyRepository(IUnitOfWork uow)
            : base(uow)
        {
            Context.Studies.Include(s => s.EntityStrings).ToList();
        }

        public IEnumerable<Study> FindAll(string culture)
        {
            return Context.Studies
                            .Select(s => new
                            {
                                Code = s.STDCODE,
                                Description = s.STDDESCRIPTION,
                                Picture = s.STDPICTURE,
                                Name = s.EntityStrings.FirstOrDefault(e => e.CLTCODE.Equals(culture)) == null ?
                                            s.STDNAME : s.EntityStrings.FirstOrDefault(e => e.CLTCODE.Equals(culture)).ESTWORDING
                            })
                            .AsEnumerable()
                            .Select(x => new Study
                            {
                                STDCODE = x.Code,
                                STDDESCRIPTION = x.Description,
                                STDPICTURE = x.Picture,
                                STDNAME = x.Name
                            });
        }

        public string GetPicture(Guid studyId)
        {
            return Context.Studies
                            .Where(study => study.STDCODE.Equals(studyId))
                            .Select(study => study.STDPICTURE)
                            .FirstOrDefault();
        }
    }
}
