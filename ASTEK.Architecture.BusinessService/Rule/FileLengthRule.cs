using ASTEK.Architecture.Infrastructure.Validator.Abstract;
using FluentValidation.Results;

namespace ASTEK.Architecture.BusinessService.Rule
{
    public class FileLengthRule : IRule
    {
        private readonly int _fileLength;
        private readonly int _maxLength;

        public FileLengthRule(int fileLength, int maxLength)
        {
            _fileLength = fileLength;
            _maxLength = maxLength;
        }

        public ValidationFailure Validate()
        {
            ValidationFailure result = null;

            if(_fileLength > _maxLength)
            {
                result = new ValidationFailure("FileLength", string.Format(BusinessStrings.BusinessValidation_FileLength));
            }

            return result;
        }
    }
}
