using ASTEK.Architecture.Domain.Entity.AnswerExercice;
using ASTEK.Architecture.Infrastructure.UnitOfWork;
using System;
using System.Linq;

namespace ASTEK.Architecture.Repository.Concrete
{
    public class EFAnswerExerciceRepository : EFRepository<AnswerExercice, Guid>, IAnswerExerciceRepository
    {
        public EFAnswerExerciceRepository(IUnitOfWork uow)
            : base(uow)
        {
        }

        public AnswerExercice Upload(AnswerExercice answer)
        {
            var exist = Context.AnswerExercices.FirstOrDefault(l => l.ACCID.Equals(answer.ACCID) && l.LSNID.Equals(answer.LSNID));

            if(exist != null)
            {
                throw new InvalidOperationException();
            }

            Add(answer);

            return answer;
        }
    }
}
