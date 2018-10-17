using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASTEK.Architecture.Infrastructure.Utility
{
    public static class ListUtilities
    {
        public static bool HasIndex(int index, IList list)
        {
            return (list.Count > index);
        }

        public static int GetTotalPagesCount(int listCount, int pageSize)
        {
            double result = (double)listCount / (double)pageSize;

            result = Math.Ceiling(result);
               
            return Convert.ToInt32(result == 0 ? 1 : result);
        }
    }
}
