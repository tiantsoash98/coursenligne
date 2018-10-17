using ASTEK.Architecture.Infrastructure.DTO;
using System;
using System.IO;

namespace ASTEK.Architecture.BusinessService.Entity.Account
{
    public class UploadAccountImageRequest: Request
    {
        public Guid AccountId { get; set; }
        public Stream Stream { get; set; }
        public string ContentType { get; set; }
        public int ContentLength { get; set; }
        public string FileName { get; set; }
    }
}
