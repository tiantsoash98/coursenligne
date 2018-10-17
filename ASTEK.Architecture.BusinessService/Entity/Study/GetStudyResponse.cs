using ASTEK.Architecture.Infrastructure.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASTEK.Architecture.BusinessService.Entity.Study
{
    public class GetStudyResponse: Response
    {
        public Domain.Entity.Study.Study Study { get; set; }
    }
}
