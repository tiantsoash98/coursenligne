using System;

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
