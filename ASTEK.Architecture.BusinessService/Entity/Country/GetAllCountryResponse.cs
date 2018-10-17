using ASTEK.Architecture.Infrastructure.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASTEK.Architecture.BusinessService.Entity.Country
{
    public class GetAllCountryResponse: Response
    {
        public List<Domain.Entity.Country.Country> Countries { get; set; }
    }
}
