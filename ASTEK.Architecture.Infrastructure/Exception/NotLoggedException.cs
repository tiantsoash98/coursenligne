using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASTEK.Architecture.Infrastructure.Exception
{
    [Serializable]
    public sealed class NotLoggedException : ApplicationException
    {
        public NotLoggedException() { }
        public NotLoggedException(string message) : base(message) { }
        public NotLoggedException(string message, System.Exception inner) : base(message, inner) { }

        private NotLoggedException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context)
        { }
    }
}
