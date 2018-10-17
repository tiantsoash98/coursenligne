using ASTEK.Architecture.BusinessService.Entity.Exercice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASTEK.Architecture.BusinessService.Interface
{
    public interface IExerciceBusinessService
    {
        CountExerciceGroupByLessonResponse Count(CountExerciceGroupByLessonRequest request);
    }
}
