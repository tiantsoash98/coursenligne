using ASTEK.Architecture.Infrastructure.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASTEK.Architecture.Repository.Concrete
{
    public class EFFollowStateRepository : EFRepository<Domain.Entity.FollowState.FollowState, Guid>, Domain.Entity.FollowState.IFollowStateRepository
    {
        public EFFollowStateRepository(IUnitOfWork uow)
            : base(uow)
        {
        }
    }
}
