namespace ASTEK.Architecture.Domain.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ExerciceQuestionType")]
    public partial class ExerciceQuestionType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ExerciceQuestionType()
        {
            ExerciceQuestions = new HashSet<ExerciceQuestion>();
        }

        [Key]
        public Guid EQTCODE { get; set; }

        [Required]
        [StringLength(25)]
        public string EQTWORDING { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ExerciceQuestion> ExerciceQuestions { get; set; }
    }
}
