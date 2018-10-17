using ASTEK.Architecture.BusinessService.Interface;
using ASTEK.Architecture.Repository;
using ASTEK.Architecture.Repository.Concrete;
using System.Linq;

namespace ASTEK.Architecture.BusinessService.Entity.Country
{
    public class CountryBusinessService : ICountryBusinessService
    {
        private readonly EFCountryRepository _repository;

        public CountryBusinessService()
        {
            var context = new EFDbContext();
            _repository = new EFCountryRepository(context);
        }

        public GetAllCountryResponse GetAll(GetAllCountryRequest request)
        {
            var response = new GetAllCountryResponse()
            {
                Countries = _repository.FindAll().ToList()
            };

            return response;
        }
    }
}
