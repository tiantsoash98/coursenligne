namespace ASTEK.Architecture.Domain.Entity.LessonPart
{
    using ASTEK.Architecture.Domain.Validator;
    using FluentValidation.Attributes;
    using Infrastructure.Domain;
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("LessonPart")]
    [Validator(typeof(LessonPartValidator))]
    public partial class LessonPart: EntityBase<Guid>, IAggregateRoot
    {
        [Key]
        public Guid LSPCODE { get; set; }

        public Guid LSCCODE { get; set; }

        public short LSPNUMBER { get; set; }

        [Required]
        [StringLength(200)]
        public string LSPTITLE { get; set; }

        [Required]
        [StringLength(50000)]
        public string LSPCONTENT { get; set; }

        [ForeignKey("LSCCODE")]
        public virtual LessonChapter.LessonChapter LessonChapter { get; set; }
    }
}
