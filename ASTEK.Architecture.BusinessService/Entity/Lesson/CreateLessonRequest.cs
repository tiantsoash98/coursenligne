using ASTEK.Architecture.Infrastructure.DTO;
using System;

namespace ASTEK.Architecture.BusinessService.Entity.Lesson
{
    public class CreateLessonRequest: Request
    {
        public Guid AccountId { get; set; }
        public string Title { get; set; }
        public Guid Study { get; set; }
        public string Description { get; set; }
        public string Target { get; set; }
        public long? Duration { get; set; }
        public Guid Confidentiality { get; set; }
    }
}