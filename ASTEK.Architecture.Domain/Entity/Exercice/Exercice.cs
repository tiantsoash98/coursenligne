namespace ASTEK.Architecture.Domain.Entity.Exercice
{
    using Infrastructure.Domain;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Exercice")]
    public partial class Exercice: EntityBase<Guid>, IAggregateRoot
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Exercice()
        {
            ExerciceDones = new HashSet<ExerciceDone>();
            ExerciceQuestions = new HashSet<ExerciceQuestion>();
        }

        [Key]
        public Guid EXCID { get; set; }

        public Guid LSNID { get; set; }

        [StringLength(200)]
        public string EXCTITLE { get; set; }

        [StringLength(1000)]
        public string EXCDESCRIPTION { get; set; }

        public DateTime EXCDATE { get; set; }

        [StringLength(500)]
        public string EXCCOMMENT { get; set; }

        public long? EXCDURATION { get; set; }

        [ForeignKey("LSNID")]
        public virtual Lesson.Lesson Lesson { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ExerciceDone> ExerciceDones { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ExerciceQuestion> ExerciceQuestions { get; set; }
    }
}
