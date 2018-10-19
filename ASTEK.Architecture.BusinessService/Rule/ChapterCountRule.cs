using ASTEK.Architecture.Infrastructure.Validator.Abstract;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASTEK.Architecture.BusinessService.Rule
{
    public class ChapterCountRule: IRule
    {
        public int ChapterCount { get; set; }

        public ChapterCountRule(int chapterCount)
        {
            this.ChapterCount = chapterCount;
        }

        public ValidationFailure Validate()
        {
            ValidationFailure result = null;

            if (ChapterCount < 1)
            {
                result = new ValidationFailure("ChapterCount", string.Format(BusinessStrings.BusinessValidation_ChapterCount));
            }

            return result;
        }
    }
}
