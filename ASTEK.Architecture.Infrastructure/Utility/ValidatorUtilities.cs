using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASTEK.Architecture.Infrastructure.Utility
{
    public static class ValidatorUtilities
    {
        public static string GetErrorsToString(ValidationResult validationResult)
        {
            var sb = new StringBuilder();

            foreach(var error in validationResult.Errors)
            {
                sb.AppendLine(error.ErrorMessage);
            }

            return sb.ToString();
        }
    }
}
