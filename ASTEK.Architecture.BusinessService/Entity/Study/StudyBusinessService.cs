using ASTEK.Architecture.BusinessService.Interface;
using ASTEK.Architecture.Infrastructure.Exception;
using ASTEK.Architecture.Repository;
using ASTEK.Architecture.Repository.Concrete;
using System.Collections.Generic;
using System.Linq;

namespace ASTEK.Architecture.BusinessService.Entity.Study
{
    public class StudyBusinessService : IStudyBusinessService
    {
        private readonly EFStudyRepository _repository;

        public StudyBusinessService()
        {
            var context = new EFDbContext();
            _repository = new EFStudyRepository(context);
        }

        public GetStudyResponse Get(GetStudyRequest request)
        {
            var study = _repository.FindBy(request.Code);

            if (!string.IsNullOrEmpty(request.Culture))
            {
                study.STDNAME = study.EntityStrings.FirstOrDefault(e => e.CLTCODE.Equals(request.Culture)) == null ?
                                            study.STDNAME : study.EntityStrings.FirstOrDefault(e => e.CLTCODE.Equals(request.Culture)).ESTWORDING;
            }

            if(study == null)
            {
                return new GetStudyResponse()
                {
                    Success = false,
                    Exception = new EntityNotFoundException(Infrastructure.InfrastructureStrings.NotFound_Study)
                };
            }

            return new GetStudyResponse()
            {
                Success = true,
                Study = study
            };
        }

        public GetAllStudyResponse GetAll(GetAllStudyRequest request)
        {
            List<Domain.Entity.Study.Study> studies = null;

            if (string.IsNullOrEmpty(request.Culture))
            {
                studies = _repository.FindAll().ToList();
            }
            else
            {
                studies = _repository.FindAll(request.Culture).ToList();
            }

            var response = new GetAllStudyResponse()
            {
                Success = true,
                Studies = studies
            };

            return response;
        }
    }
}
