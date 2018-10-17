using ASTEK.Architecture.Infrastructure.DTO;

namespace ASTEK.Architecture.BusinessService.Entity.Account
{
    public class GetAllInformationsAccountResponse: Response
    {
        public Domain.Entity.Account.Account Account { get; set; }
    }
}
