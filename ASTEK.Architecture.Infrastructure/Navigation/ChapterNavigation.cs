using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASTEK.Architecture.Infrastructure.Navigation
{
    public class ChapterNavigation
    {
        public short Number { get; set; }
        public string Title { get; set; }
        public List<PartNavigation> Parts { get; set; }

        public int CountTotalParts()
        {
            return Parts != null ? Parts.Count : 0;
        }

        public int CountTotalParts(short partLimit)
        {
            if(Parts == null || partLimit == 0)
            {
                return 0;
            }

            if(Parts.Last().Number < partLimit)
            {
                throw new ArgumentOutOfRangeException("partLimit");
            }

            int result = 0;

            foreach(var part in Parts)
            {
                if(part.Number > partLimit)
                {
                    break;
                }

                result++;
            }

            return result;
        }
    }
}
