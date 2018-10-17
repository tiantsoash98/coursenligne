using ASTEK.Architecture.BusinessService.Interface;
using ASTEK.Architecture.Repository;
using ASTEK.Architecture.Repository.Concrete;
using System.Linq;

namespace ASTEK.Architecture.BusinessService.Entity.Culture
{
    public class CultureBusinessService : ICultureBusinessService
    {
        private readonly EFCultureRepository _repository;

        public CultureBusinessService()
        {
            var context = new EFDbContext();
            _repository = new EFCultureRepository(context);
        }

        public GetAllCultureResponse GetAll(GetAllCultureRequest request)
        {
            var response = new GetAllCultureResponse()
            {
                Success = true,
                Cultures = _repository.FindAll().ToList()
            };

            return response;
        }
    }
}
