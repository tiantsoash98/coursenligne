using ASTEK.Architecture.Infrastructure.DTO;
using System.Collections.Generic;

namespace ASTEK.Architecture.BusinessService.Entity.Study
{
    public class GetAllStudyResponse: Response
    {
        public List<Domain.Entity.Study.Study> Studies { get; set; }
    }
}
