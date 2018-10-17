using ASTEK.Architecture.BusinessService.Entity.Exercice;
using ASTEK.Architecture.BusinessService.Interface;
using ASTEK.Architecture.Infrastructure.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASTEK.Architecture.ApplicationService.Entity.Exercice
{
    public class ExerciceAppService
    {
        private readonly IExerciceBusinessService _service;

        public ExerciceAppService()
        {
            _service = new ExerciceBusinessService();
        }

        public CountExerciceGroupByLessonOutputModel Count(CountExerciceGroupByLessonInputModel input)
        {
            var request = new CountExerciceGroupByLessonRequest()
            {
                LessonId = GuidUtilities.TryParse(input.LessonId)
            };

            return new CountExerciceGroupByLessonOutputModel()
            {
                Response = _service.Count(request)
            };
        }
    }
}
