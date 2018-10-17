namespace ASTEK.Architecture.Domain.Entity.DocumentState
{
    using ASTEK.Architecture.Infrastructure.Domain;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("DocumentState")]
    public partial class DocumentState: EntityBase<Guid>, IAggregateRoot
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DocumentState()
        {
            Lessons = new HashSet<Lesson.Lesson>();
        }

        [Key]
        public Guid DCSCODE { get; set; }

        [Required]
        [StringLength(25)]
        public string DCSWORDING { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Lesson.Lesson> Lessons { get; set; }
    }
}
