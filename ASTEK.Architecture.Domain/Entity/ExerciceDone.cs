namespace ASTEK.Architecture.Domain.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ExerciceDone")]
    public partial class ExerciceDone
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ExerciceDone()
        {
            ExerciceCorrections = new HashSet<ExerciceCorrection>();
            ExerciceQuestionAnswers = new HashSet<ExerciceQuestionAnswer>();
        }

        [Key]
        public Guid EXDID { get; set; }

        public Guid EXCID { get; set; }

        public Guid ACCID { get; set; }

        public DateTime EXDDATE { get; set; }

        [StringLength(500)]
        public string EXDCOMMENT { get; set; }

        public virtual Account.Account Account { get; set; }

        public virtual Exercice.Exercice Exercice { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ExerciceCorrection> ExerciceCorrections { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ExerciceQuestionAnswer> ExerciceQuestionAnswers { get; set; }
    }
}
