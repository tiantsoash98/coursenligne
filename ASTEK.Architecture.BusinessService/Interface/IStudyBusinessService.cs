using ASTEK.Architecture.BusinessService.Entity.Study;

namespace ASTEK.Architecture.BusinessService.Interface
{
    public interface IStudyBusinessService
    {
        GetAllStudyResponse GetAll(GetAllStudyRequest request);
        GetStudyResponse Get(GetStudyRequest request);
    }
}
