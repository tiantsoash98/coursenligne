using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASTEK.Architecture.Infrastructure.Utility
{
    public static class TimeSpanUtilities
    {
        public static string Display(long? ticks)
        {
            long _ticks = ticks.GetValueOrDefault();

            if (ticks == 0)
                return "-";

            var timeSpan = new TimeSpan(_ticks);

            return timeSpan.ToString();
        }
    }
}
