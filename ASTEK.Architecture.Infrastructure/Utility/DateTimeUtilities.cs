using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASTEK.Architecture.Infrastructure.Utility
{
    public static class DateTimeUtilities
    {
        public static int GetDateOfWeek(DateTime time)
        {
            int result = 0;

            if (time.DayOfWeek == DayOfWeek.Monday)
            {
                result = 0;
            }
            else if (time.DayOfWeek == DayOfWeek.Tuesday)
            {
                result = 1;
            }
            else if (time.DayOfWeek == DayOfWeek.Wednesday)
            {
                result = 2;
            }
            else if (time.DayOfWeek == DayOfWeek.Thursday)
            {
                result = 3;
            }
            else if (time.DayOfWeek == DayOfWeek.Friday)
            {
                result = 4;
            }
            else if (time.DayOfWeek == DayOfWeek.Saturday)
            {
                result = 5;
            }
            else if (time.DayOfWeek == DayOfWeek.Sunday)
            {
                result = 6;
            }

            return result;
        }

        public static DateTime GetMondayOfWeekFrom(DateTime reference)
        {
            return reference.AddDays(-GetDateOfWeek(reference));
        }

        public static List<DateTime> GetCurrentWeek(DateTime reference)
        {
            List<DateTime> week = new List<DateTime>();

            DateTime monday = GetMondayOfWeekFrom(reference);

            for (int i = 0; i < 7; i++)
            {
                week.Add(monday.AddDays(i));
            }

            return week;
        }
    }
}
