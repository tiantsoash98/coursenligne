using System.Collections.Generic;

namespace ASTEK.Architecture.ApplicationService.Entity.LessonPart
{
    public class CreateAllLessonPartInputModel
    {
        public string ChapterCode { get; set; }
        public List<CreateLessonPartInputModel> PartsInput { get; set; }
    }
}
