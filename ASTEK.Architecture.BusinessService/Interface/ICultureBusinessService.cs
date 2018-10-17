using ASTEK.Architecture.BusinessService.Entity.Culture;

namespace ASTEK.Architecture.BusinessService.Interface
{
    public interface ICultureBusinessService
    {
        GetAllCultureResponse GetAll(GetAllCultureRequest request);
    }
}
