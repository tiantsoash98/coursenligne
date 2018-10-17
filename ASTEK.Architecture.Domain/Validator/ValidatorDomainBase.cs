using ASTEK.Architecture.Infrastructure.Domain;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASTEK.Architecture.Domain.Validator
{
    public abstract class ValidatorDomainBase<T, TId> : AbstractValidator<T> where T : EntityBase<TId>
    {
        protected ValidatorDomainBase(ValidationType validationType)
        {
        }
    }
}
