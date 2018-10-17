using ASTEK.Architecture.Infrastructure.DTO;
using System.Collections.Generic;

namespace ASTEK.Architecture.BusinessService.Entity.Culture
{
    public class GetAllCultureResponse: Response
    {
        public List<Domain.Entity.Culture.Culture> Cultures { get; set; }
    }
}
