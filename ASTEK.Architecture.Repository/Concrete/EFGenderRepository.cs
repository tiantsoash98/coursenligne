using ASTEK.Architecture.Domain.Entity.Gender;
using ASTEK.Architecture.Infrastructure.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace ASTEK.Architecture.Repository.Concrete
{
    public class EFGenderRepository : EFRepository<Gender, Guid>, IGenderRepository
    {
        public EFGenderRepository(IUnitOfWork uow)
            : base(uow)
        {
            Context.Studies.Include(s => s.EntityStrings).ToList();
        }

        public IEnumerable<Gender> FindAll(string culture)
        {
            return Context.Genders
                            .Select(g => new
                            {
                                Code = g.GENCODE,
                                Wording = g.EntityStrings.FirstOrDefault(e => e.CLTCODE.Equals(culture)) == null ?
                                            g.GENWORDING : g.EntityStrings.FirstOrDefault(e => e.CLTCODE.Equals(culture)).ESTWORDING
                            })
                            .AsEnumerable()
                            .Select(x => new Gender
                            {
                                GENCODE = x.Code,
                                GENWORDING = x.Wording
                            });
        }
    }
}
