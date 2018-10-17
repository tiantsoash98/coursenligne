namespace ASTEK.Architecture.Domain.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ExerciceQuestionChoice")]
    public partial class ExerciceQuestionChoice
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ExerciceQuestionChoice()
        {
            ExerciceQuestions = new HashSet<ExerciceQuestion>();
        }

        [Key]
        public Guid EQCCODE { get; set; }

        [Required]
        [StringLength(500)]
        public string EQCANWSER { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ExerciceQuestion> ExerciceQuestions { get; set; }
    }
}
