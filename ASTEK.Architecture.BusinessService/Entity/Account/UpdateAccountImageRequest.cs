using ASTEK.Architecture.Infrastructure.DTO;
using System;

namespace ASTEK.Architecture.BusinessService.Entity.Account
{
    public class UpdateAccountImageRequest: Request
    {
        public Guid AccountId { get; set; }
        public string ImageName { get; set; }
    }
}
