namespace ASTEK.Architecture.Domain.Entity.LessonChapter
{
    using FluentValidation.Attributes;
    using Infrastructure.Domain;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using Validator;

    [Table("LessonChapter")]
    [Validator(typeof(LessonChapterValidator))]
    public partial class LessonChapter: EntityBase<Guid>, IAggregateRoot
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LessonChapter()
        {
            LessonParts = new HashSet<LessonPart.LessonPart>();
        }

        [Key]
        public Guid LSCCODE { get; set; }

        public Guid LSNID { get; set; }

        public short LSCNUMBER { get; set; }

        [Required]
        [StringLength(200)]
        public string LSCTITLE { get; set; }

        [StringLength(2000)]
        public string LSCDESCRIPTION { get; set; }

        [Required]
        public string LSCCONTENT { get; set; }

        public long? LSCDURATION { get; set; }

        [ForeignKey("LSNID")]
        public virtual Lesson.Lesson Lesson { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LessonPart.LessonPart> LessonParts { get; set; }
    }
}
