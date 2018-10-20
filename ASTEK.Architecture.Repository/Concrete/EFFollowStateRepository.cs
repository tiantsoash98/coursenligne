using ASTEK.Architecture.Infrastructure.UnitOfWork;
using System;

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
