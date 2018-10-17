using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASTEK.Architecture.Infrastructure.Utility
{
    public static class GuidUtilities
    {
        public static Guid TryParse(string id)
        {
            Guid.TryParse(id, out Guid guid);
            return guid;
        }
    }
}
