using ASTEK.Architecture.Infrastructure.Validator.Abstract;
using FluentValidation.Results;
using System.Collections.Generic;

namespace ASTEK.Architecture.BusinessService.Rule
{
    public class ImageFileExtensionRule : IRule
    {
        private readonly string _fileExtension;

        public ImageFileExtensionRule(string fileExtension)
        {
            _fileExtension = fileExtension;
        }

        public ValidationFailure Validate()
        {
            ValidationFailure result = null;

            List<string> allowedExtensions = new List<string> { ".jpg", ".jpeg", ".png", ".gif" };

            if (!allowedExtensions.Contains(_fileExtension.ToLower()))
            {
                result = new ValidationFailure("FileExtension", string.Format(BusinessStrings.BusinessValidation_ImageExtension, _fileExtension.Substring(1)));
            }

            return result;
        }
    }
}
