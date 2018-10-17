namespace ASTEK.Architecture.Domain.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ExerciceQuestion")]
    public partial class ExerciceQuestion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ExerciceQuestion()
        {
            ExerciceQuestionAnswers = new HashSet<ExerciceQuestionAnswer>();
        }

        [Key]
        public Guid EXQCODE { get; set; }

        public Guid EXCID { get; set; }

        public Guid? FLDCODE { get; set; }

        public Guid EQTCODE { get; set; }

        public Guid? EQCCODE { get; set; }

        public short EXQNUMBER { get; set; }

        [Required]
        [StringLength(500)]
        public string EXQQUESTION { get; set; }

        [StringLength(1000)]
        public string EXQANSWER { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? EXQPOINTS { get; set; }

        [ForeignKey("EXCID")]
        public virtual Exercice.Exercice Exercice { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ExerciceQuestionAnswer> ExerciceQuestionAnswers { get; set; }

        public virtual FieldType FieldType { get; set; }

        public virtual ExerciceQuestionType ExerciceQuestionType { get; set; }

        public virtual ExerciceQuestionChoice ExerciceQuestionChoice { get; set; }
    }
}
