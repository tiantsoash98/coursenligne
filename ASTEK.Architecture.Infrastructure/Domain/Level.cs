using System.Collections.Generic;

namespace ASTEK.Architecture.Infrastructure.Domain
{
    public class Level
    {
        public string Wording { get; set; }
        public int Value { get; set; }

        public static List<Level> GetLevels()
        {
            return new List<Level>
            {
                new Level{ Value = 1, Wording = GetWording(1) },
                new Level{ Value = 2, Wording = GetWording(2) },
                new Level{ Value = 3, Wording = GetWording(3) },
                new Level{ Value = 4, Wording = GetWording(4) },
                new Level{ Value = 5, Wording = GetWording(5) },
                new Level{ Value = 6, Wording = GetWording(6) },
            };
        }

        public static string GetWording(int level, bool shorten = false)
        {
            string wording = string.Empty;

            switch (level)
            {
                case 1:
                    wording = shorten ? "L1" : "Licence - 1ère année";
                    break;
                case 2:
                    wording = shorten ? "L2" : "Licence - 2ème année";
                    break;
                case 3:
                    wording = shorten ? "L3" : "Licence - 3ème année";
                    break;
                case 4:
                    wording = shorten ? "M1" : "Master - 1ère année";
                    break;
                case 5:
                    wording = shorten ? "M2" : "Master - 2ème année";
                    break;
                case 6:
                    wording = shorten ? "Doc." : "Doctorat";
                    break;
                default:
                    wording = string.Empty;
                    break;
            }

            return wording;
        }
    }
}
