using ASTEK.Architecture.Infrastructure.Domain;
using ASTEK.Architecture.Infrastructure.DTO;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASTEK.Architecture.BusinessService.Abstract
{
    public abstract class EntityServiceBase<T> where T: EntityBase<Guid>
    {
        public abstract List<ValidationFailure> GetErrors(T entity, ValidationType validationType);
        public void ThrowExceptionIfIsInvalid(T entity, ValidationType validationType)
        {
            List<ValidationFailure> errors = GetErrors(entity, validationType);

            if (errors.Any())
            {
                var stringBuilder = new StringBuilder();

                foreach (var error in errors)
                {
                    stringBuilder.AppendLine(error.ErrorMessage);
                }

                throw new ArgumentException(stringBuilder.ToString());
            }
        }
    }
}
