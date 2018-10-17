using ASTEK.Architecture.BusinessService.Entity.DocumentConfidentiality;
using ASTEK.Architecture.BusinessService.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASTEK.Architecture.ApplicationService.Entity.DocumentConfidentiality
{
    public class DocumentConfidentialityAppService
    {
        private readonly IDocumentConfidentialityService _service;

        public DocumentConfidentialityAppService()
        {
            _service = new DocumentConfidentialityBusinessService();
        }


        public GetAllDocumentConfidentialityOutputModel GetAll(GetAllDocumentConfidentialityInputModel input)
        {
            var request = new GetAllDocumentConfidentialityRequest();

            return new GetAllDocumentConfidentialityOutputModel()
            {
                Response = _service.GetAll(request)
            };
        }
    }
}
