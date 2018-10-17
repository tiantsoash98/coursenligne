using ASTEK.Architecture.BusinessService.Entity.Country;

namespace ASTEK.Architecture.BusinessService.Interface
{
    public interface ICountryBusinessService
    {
        GetAllCountryResponse GetAll(GetAllCountryRequest request);
    }
}
