using System.IO;

namespace ASTEK.Architecture.ApplicationService.Entity.Account
{
    public class UploadAccountImageInputModel
    {
        public string Account { get; set; }
        public Stream Stream { get; set; }
        public string ContentType { get; set; }
        public int ContentLength { get; set; }
        public string FileName { get; set; }
    }
}
