using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASTEK.Architecture.Infrastructure.Exception
{
    [Serializable]
    public sealed class AccountNotFoundException : ApplicationException
    {
        public AccountNotFoundException() { }
        public AccountNotFoundException(string message) : base(message) { }
        public AccountNotFoundException(string message, System.Exception inner) : base(message, inner) { }

        private AccountNotFoundException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context)
        { }
    }
}
