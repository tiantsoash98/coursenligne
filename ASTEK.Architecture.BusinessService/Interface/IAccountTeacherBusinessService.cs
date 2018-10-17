using ASTEK.Architecture.BusinessService.Entity.AccountTeacher;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASTEK.Architecture.BusinessService.Interface
{
    public interface IAccountTeacherBusinessService
    {
        CreateAccountTeacherResponse Create(CreateAccountTeacherRequest request);
        UpdateAccountTeacherResponse Update(UpdateAccountTeacherRequest request);
    }
}
