using System;
using System.Collections.Generic;
using System.Linq;

namespace ASTEK.Architecture.Infrastructure.Navigation
{
    public class LessonNavigation
    {
        public Guid LessonId { get; set; }
        public List<ChapterNavigation> Chapters { get; set; }

        public int CountTotalElements()
        {
            if (Chapters == null)
            {
                return 0;
            }

            int result = 0;

            Chapters.ForEach(chapter =>
            {
                result++;
                result += chapter.CountTotalParts();
            });
            
            return result;
        }

        public int CountTotalElements(short chapterNumber, short? partNumber)
        {
            if(Chapters == null || chapterNumber == 0)
            {
                return 0;
            }

            if(Chapters.Last().Number < chapterNumber)
            {
                throw new ArgumentOutOfRangeException("chapterNumber");
            }

            int result = 0;

            foreach(var chapter in Chapters)
            {
                if(chapter.Number > chapterNumber)
                {
                    break;
                }

                result++;

                if (chapter.Number == chapterNumber && partNumber.HasValue)
                {
                    result += chapter.CountTotalParts(partNumber.Value);
                }
                else
                {
                    result += chapter.CountTotalParts();
                }
            }

            return result;
        }

        public int GetProgression(short chapterNumber, short? partNumber)
        {
            int totalElements = CountTotalElements();
            int totalAt = CountTotalElements(chapterNumber, partNumber);
            double pourcentage = (totalAt / (double)totalElements) * 100;

            return (int)pourcentage;
        }
    }
}
