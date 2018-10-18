namespace ASTEK.Architecture.UI.MVC.Models.Lesson
{
    public class LessonAlternativePictureViewModel: BaseViewModel
    {
        public string PicturePath { get; set; }
        public string LessonTitle { get; set; }
        public string StudyName { get; set; }
        public bool IsAlternative { get; set; }
    }
}