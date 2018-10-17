using ASTEK.Architecture.BusinessService.Entity.Study;
using ASTEK.Architecture.BusinessService.Interface;
using ASTEK.Architecture.Infrastructure.Utility;

namespace ASTEK.Architecture.ApplicationService.Entity.Study
{
    public class StudyAppService
    {
        private readonly IStudyBusinessService _service;

        public StudyAppService()
        {
            _service = new StudyBusinessService();
        }

        public GetStudyOutputModel Get(GetStudyInputModel input)
        {
            var request = new GetStudyRequest
            {
                Code = GuidUtilities.TryParse(input.Code),
                Culture = input.Culture
            };

            return new GetStudyOutputModel
            {
                Response = _service.Get(request)
            };
        }

        public GetAllStudyOutputModel GetAll(GetAllStudyInputModel input)
        {
            var request = new GetAllStudyRequest
            {
                Culture = input.Culture
            };

            return new GetAllStudyOutputModel
            {
                Response = _service.GetAll(request)
            };
        }
    }
}
