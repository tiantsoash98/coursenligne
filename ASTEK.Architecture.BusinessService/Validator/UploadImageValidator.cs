using ASTEK.Architecture.BusinessService.Rule;
using ASTEK.Architecture.Infrastructure.Validator.Abstract;
using System.IO;

namespace ASTEK.Architecture.BusinessService.Validator
{
    public class UploadImageValidator : ValidatorBusinessBase
    {
        private readonly Stream Stream;
        private readonly string Extension;
        private readonly int ContentLength;
        private readonly int MaxLength;

        public UploadImageValidator(Stream stream, string fileExtension, int fileContentLength, int maxLength)
        {
            Stream = stream;
            Extension = fileExtension;
            ContentLength = fileContentLength;
            MaxLength = maxLength;
        }

        public override void AddRules()
        {
            AddRule(new ImageFileExtensionRule(Extension));
            AddRule(new FileLengthRule(ContentLength, MaxLength));
        }
    }
}
