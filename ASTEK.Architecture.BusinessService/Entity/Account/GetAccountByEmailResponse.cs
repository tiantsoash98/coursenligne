using ASTEK.Architecture.Infrastructure.DTO;

namespace ASTEK.Architecture.BusinessService.Entity.Account
{
    public class GetAccountByEmailResponse: Response
    {
        public Domain.Entity.Account.Account Account { get; set; }
    }
}
