using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASTEK.Architecture.BusinessService.Entity.Gender
{
    public class GetAllGenderResponse
    {
        public List<Domain.Entity.Gender.Gender> Genders { get; set; }
    }
}
