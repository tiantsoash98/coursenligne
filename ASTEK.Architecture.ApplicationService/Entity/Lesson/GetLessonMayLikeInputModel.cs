﻿namespace ASTEK.Architecture.ApplicationService.Entity.Lesson
{
    public class GetLessonMayLikeInputModel
    {
        public int Page { get; set; }
        public int Count { get; set; }
        public bool GetAlternativePicture { get; set; }
        public bool GetThumbnailPicture { get; set; }
        public int Level { get; set; }
    }
}
