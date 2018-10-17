using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASTEK.Architecture.Infrastructure.DTO
{
    public class Response
    {
        public System.Exception Exception { get; set; }
        public bool Success { get; set; }
        public long Count { get; set; }
        public int Page { get; set; }
        public int Skip { get; set; }
        public int TotalPages { get; set; }
    }
}
