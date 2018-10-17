namespace ASTEK.Architecture.Domain.Entity.DocumentConfidentiality
{
    using Infrastructure.Domain;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DocumentConfidentiality")]
    public partial class DocumentConfidentiality: EntityBase<Guid>, IAggregateRoot
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DocumentConfidentiality()
        {
            Lessons = new HashSet<Lesson.Lesson>();
        }

        [Key]
        public Guid DCFCODE { get; set; }

        [Required]
        [StringLength(25)]
        public string DCFWORDING { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Lesson.Lesson> Lessons { get; set; }
    }
}
