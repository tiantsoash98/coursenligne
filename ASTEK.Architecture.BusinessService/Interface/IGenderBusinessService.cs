using ASTEK.Architecture.BusinessService.Entity.Gender;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASTEK.Architecture.BusinessService.Interface
{
    public interface IGenderBusinessService
    {
        GetAllGenderResponse GetAll(GetAllGenderRequest request);
    }
}
