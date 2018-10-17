using ASTEK.Architecture.BusinessService.Entity.Country;
using ASTEK.Architecture.BusinessService.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASTEK.Architecture.ApplicationService.Entity.Country
{
    public class CountryAppService
    {
        private readonly ICountryBusinessService _service;

        public CountryAppService()
        {
            _service = new CountryBusinessService();
        }


        public GetAllCountryOutputModel GetAll(GetAllCountryInputModel input)
        {
            var request = new GetAllCountryRequest();

            return new GetAllCountryOutputModel()
            {
                Response = _service.GetAll(request)
            };
        }
    }
}
