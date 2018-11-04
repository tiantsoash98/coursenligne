using System;

namespace ASTEK.Architecture.ApplicationService.Entity.Lesson
{
    public class CountLessonPostedByInputModel
    {
        public string AccountId { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
    }
}
