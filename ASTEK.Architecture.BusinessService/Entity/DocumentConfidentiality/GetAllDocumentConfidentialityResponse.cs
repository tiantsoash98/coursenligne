using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASTEK.Architecture.BusinessService.Entity.DocumentConfidentiality
{
    public class GetAllDocumentConfidentialityResponse
    {
        public List<Domain.Entity.DocumentConfidentiality.DocumentConfidentiality> DocumentsConfidentialities { get; set; }
    }
}
