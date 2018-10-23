using ASTEK.Architecture.Infrastructure.DTO;
using System;

namespace ASTEK.Architecture.BusinessService.Entity.Lesson
{
    public class PublishLessonRequest: Request
    {
        public Guid AccountId { get; set; }
        public Guid LessonId { get; set; }
        public string UrlPath { get; set; }
    }
}
