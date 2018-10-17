using ASTEK.Architecture.BusinessService.Interface;
using ASTEK.Architecture.Repository;
using ASTEK.Architecture.Repository.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASTEK.Architecture.BusinessService.Entity.DocumentConfidentiality
{
    public class DocumentConfidentialityBusinessService : IDocumentConfidentialityService
    {
        private readonly EFDocumentConfidentialityRepository _repository;

        public DocumentConfidentialityBusinessService()
        {
            var context = new EFDbContext();
            _repository = new EFDocumentConfidentialityRepository(context);
        }

        public GetAllDocumentConfidentialityResponse GetAll(GetAllDocumentConfidentialityRequest request)
        {
            var response = new GetAllDocumentConfidentialityResponse()
            {
                DocumentsConfidentialities = _repository.FindAll().ToList()
            };

            return response;
        }
    }
}
