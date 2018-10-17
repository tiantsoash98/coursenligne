using ASTEK.Architecture.Domain.Entity.Exercice;
using ASTEK.Architecture.Infrastructure.Specification;
using ASTEK.Architecture.Infrastructure.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASTEK.Architecture.Repository.Concrete
{
    public class EFExerciceRepository : EFRepository<Exercice, Guid>, IExerciceRepository
    {
        public EFExerciceRepository(IUnitOfWork uow)
            : base(uow)
        {
        }

        public int Count(Guid lessonId)
        {
            return Count(new Specification<Exercice>(e => e.LSNID.Equals(lessonId)));
        }
    }
}
