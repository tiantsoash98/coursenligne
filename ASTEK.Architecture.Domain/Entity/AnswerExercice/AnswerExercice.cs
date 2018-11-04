namespace ASTEK.Architecture.Domain.Entity.AnswerExercice
{
    using ASTEK.Architecture.Infrastructure.Domain;
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("AnswerExercice")]
    public partial class AnswerExercice: EntityBase<Guid>, IAggregateRoot
    {
        [Key]
        public Guid ANSID { get; set; }

        public Guid ACCID { get; set; }

        public Guid LSNID { get; set; }

        public DateTime ANSDATEPOSTED { get; set; }

        [Required]
        [StringLength(100)]
        public string ANSFILE { get; set; }

        [StringLength(2000)]
        public string ANSCOMMENT { get; set; }

        public bool ANSISCORRECTED { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ANSMARK { get; set; }

        public DateTime? ANSDATECORRECTION { get; set; }

        [StringLength(2000)]
        public string ANSCOMMENTCORRECTION { get; set; }

        [StringLength(2000)]
        public string ANSVALUATION { get; set; }

        [ForeignKey("ACCID")]
        public virtual Account.Account Account { get; set; }

        [ForeignKey("LSNID")]
        public virtual Lesson.Lesson Lesson { get; set; }
    }
}
