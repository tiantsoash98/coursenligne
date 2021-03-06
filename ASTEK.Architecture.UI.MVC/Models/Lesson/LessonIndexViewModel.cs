﻿namespace ASTEK.Architecture.UI.MVC.Models.Lesson
{
    public class LessonIndexViewModel: BaseLessonViewModel
    {
        public string[] Targets { get; set; }
        public int ExerciceCount { get; set; }
        public int ChapterCount { get; set; }
        public int FollowCount { get; set; }
        public Comment.CommentSectionViewModel CommentSectionViewModel { get; set; }
    }
}