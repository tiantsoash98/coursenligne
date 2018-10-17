using ASTEK.Architecture.Infrastructure.DTO;
using System;

namespace ASTEK.Architecture.BusinessService.Entity.Account
{
    public class GetAllInformationsAccountRequest: Request
    {
        public Guid AccountId { get; set; }
    }
}
