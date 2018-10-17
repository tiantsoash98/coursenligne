using ASTEK.Architecture.BusinessService.Entity.AccountStudent;

namespace ASTEK.Architecture.BusinessService.Interface
{
    public interface IAccountStudentBusinessService
    {
        CreateAccountStudentResponse Create(CreateAccountStudentRequest request);
        UpdateAccountStudentResponse Update(UpdateAccountStudentRequest request);
    }
}
