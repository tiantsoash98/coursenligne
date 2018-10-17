namespace ASTEK.Architecture.Domain.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FieldType")]
    public partial class FieldType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FieldType()
        {
            ExerciceQuestions = new HashSet<ExerciceQuestion>();
        }

        [Key]
        public Guid FLDCODE { get; set; }

        [Required]
        [StringLength(25)]
        public string FLDWORDING { get; set; }

        public int? FLDMINSIZE { get; set; }

        public int? FLDMAXSIZE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ExerciceQuestion> ExerciceQuestions { get; set; }
    }
}
