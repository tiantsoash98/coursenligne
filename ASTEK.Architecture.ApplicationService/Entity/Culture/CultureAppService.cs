using ASTEK.Architecture.BusinessService.Entity.Culture;
using ASTEK.Architecture.BusinessService.Interface;

namespace ASTEK.Architecture.ApplicationService.Entity.Culture
{
    public class CultureAppService
    {
        private readonly ICultureBusinessService _service;

        public CultureAppService()
        {
            _service = new CultureBusinessService();
        }

        public GetAllCultureOutputModel GetAll(GetAllCultureInputModel input)
        {
            var request = new GetAllCultureRequest();

            return new GetAllCultureOutputModel
            {
                Response = _service.GetAll(request)
            };
        }
    }
}
