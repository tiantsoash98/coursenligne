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
            var newGuid = Guid.Empty;

            Guid.TryParse(id, out newGuid);
            return newGuid;
        }
    }
}
