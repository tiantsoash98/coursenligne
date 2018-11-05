namespace ASTEK.Architecture.Domain.Entity.Lesson
{
    using FluentValidation.Attributes;
    using Infrastructure.Domain;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using Validator;
    using System.Linq;

    [Table("Lesson")]
    [Validator(typeof(LessonValidator))]
    public partial class Lesson: EntityBase<Guid>, IAggregateRoot
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Lesson()
        {
            CurriculumLessons = new HashSet<CurriculumLesson>();
            Exercices = new HashSet<Exercice.Exercice>();
            LessonChapters = new HashSet<LessonChapter.LessonChapter>();
            LessonFolloweds = new HashSet<LessonFollowed.LessonFollowed>();
            AnswerExercices = new HashSet<AnswerExercice.AnswerExercice>();
        }

        [Key]
        public Guid LSNID { get; set; }

        public Guid STDCODE { get; set; }

        public Guid ACCID { get; set; }

        public Guid DCSCODE { get; set; }

        public Guid DCFCODE { get; set; }

        [Required]
        [StringLength(200)]
        public string LSNTITLE { get; set; }

        [Required]
        [StringLength(1000)]
        public string LSNDESCRIPTION { get; set; }

        [Required]
        [StringLength(500)]
        public string LSNTARGET { get; set; }

        public DateTime LSNDATE { get; set; }

        [StringLength(100)]
        public string LSNPICTURE { get; set; }

        public long? LSNDURATION { get; set; }

        public int LSNLEVEL { get; set; }

        [StringLength(100)]
        public string LSNATTACHEDSOUND { get; set; }

        [StringLength(100)]
        public string LSNATTACHEDVIDEO { get; set; }

        [StringLength(100)]
        public string LSNATTACHEDDOC { get; set; }

        [StringLength(100)]
        public string LSNATTACHEDEXC { get; set; }

        [StringLength(100)]
        public string LSNATTACHEDCORR { get; set; }

        [ForeignKey("ACCID")]
        public virtual Account.Account Account { get; set; }

        [ForeignKey("DCSCODE")]
        public virtual DocumentState.DocumentState DocumentState { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CurriculumLesson> CurriculumLessons { get; set; }

        [ForeignKey("DCFCODE")] 
        public virtual DocumentConfidentiality.DocumentConfidentiality DocumentConfidentiality { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Exercice.Exercice> Exercices { get; set; }

        [ForeignKey("STDCODE")]
        public virtual Study.Study Study { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LessonChapter.LessonChapter> LessonChapters { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LessonFollowed.LessonFollowed> LessonFolloweds { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AnswerExercice.AnswerExercice> AnswerExercices { get; set; }
    }

    public static class LessonExtensions
    {
        public static List<Lesson> PreferLevel(this List<Lesson> lessons, int level)
        {
            var result = new List<Lesson>();

            var extracted = lessons.Where(l => l.LSNLEVEL == level);
            var removed = lessons.Where(l => l.LSNLEVEL != level);

            result.AddRange(extracted);
            result.AddRange(removed);

            return result;
        }
    }
}
