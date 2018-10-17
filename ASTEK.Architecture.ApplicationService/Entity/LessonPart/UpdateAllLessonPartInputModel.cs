using System.Collections.Generic;

namespace ASTEK.Architecture.ApplicationService.Entity.LessonPart
{
    public class UpdateAllLessonPartInputModel
    {
        public string ChapterCode { get; set; }
        public List<UpdateLessonPartInputModel> PartsInput { get; set; }
    }
}
