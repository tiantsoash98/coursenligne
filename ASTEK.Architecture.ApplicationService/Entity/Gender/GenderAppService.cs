using ASTEK.Architecture.BusinessService.Entity.Gender;
using ASTEK.Architecture.BusinessService.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASTEK.Architecture.ApplicationService.Entity.Gender
{
    public class GenderAppService
    {
        private readonly IGenderBusinessService _service;

        public GenderAppService()
        {
            _service = new GenderBusinessService();
        }


        public GetAllGenderOutputModel GetAll(GetAllGenderInputModel input)
        {
            var request = new GetAllGenderRequest
            {
                Culture = input.Culture
            };

            return new GetAllGenderOutputModel()
            {
                Response = _service.GetAll(request)
            };
        }
    }
}
