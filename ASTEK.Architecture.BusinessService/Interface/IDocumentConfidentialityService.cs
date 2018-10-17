using ASTEK.Architecture.BusinessService.Entity.DocumentConfidentiality;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASTEK.Architecture.BusinessService.Interface
{
    public interface IDocumentConfidentialityService
    {
        GetAllDocumentConfidentialityResponse GetAll(GetAllDocumentConfidentialityRequest request);
    }
}
