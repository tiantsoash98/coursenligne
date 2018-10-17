using ASTEK.Architecture.BusinessService.Abstract;
using ASTEK.Architecture.BusinessService.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ASTEK.Architecture.Domain.Entity.Exercice;
using ASTEK.Architecture.Infrastructure.Domain;
using FluentValidation.Results;
using ASTEK.Architecture.Repository.Concrete;
using ASTEK.Architecture.Repository;

namespace ASTEK.Architecture.BusinessService.Entity.Exercice
{
    public class ExerciceBusinessService : EntityServiceBase<Domain.Entity.Exercice.Exercice>, IExerciceBusinessService
    {
        private readonly EFExerciceRepository _repository;

        public ExerciceBusinessService()
        {
            var context = new EFDbContext();
            _repository = new EFExerciceRepository(context);
        }

        public CountExerciceGroupByLessonResponse Count(CountExerciceGroupByLessonRequest request)
        {
            return new CountExerciceGroupByLessonResponse()
            {
                Count = _repository.Count(request.LessonId)
            };
        }

        public override List<ValidationFailure> GetErrors(Domain.Entity.Exercice.Exercice entity, ValidationType validationType)
        {
            throw new NotImplementedException();
        }
    }
}
