using ASTEK.Architecture.BusinessService.Interface;
using ASTEK.Architecture.Repository;
using ASTEK.Architecture.Repository.Concrete;
using System.Collections.Generic;
using System.Linq;

namespace ASTEK.Architecture.BusinessService.Entity.Gender
{
    public class GenderBusinessService: IGenderBusinessService
    {
        private readonly EFGenderRepository _repository;

        public GenderBusinessService()
        {
            var context = new EFDbContext();
            _repository = new EFGenderRepository(context);
        }

        public GetAllGenderResponse GetAll(GetAllGenderRequest request)
        {
            List<Domain.Entity.Gender.Gender> genders = null;

            if (string.IsNullOrEmpty(request.Culture))
            {
                genders = _repository.FindAll().ToList();
            }
            else
            {
                genders = _repository.FindAll(request.Culture).ToList();
            }

            var response = new GetAllGenderResponse()
            {
                Genders = genders
            };

            return response;
        }
    }
}
