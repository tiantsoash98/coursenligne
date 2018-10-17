using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASTEK.Architecture.Infrastructure.Validator.Abstract
{
    public interface IRule
    {
        ValidationFailure Validate();
    }
}
