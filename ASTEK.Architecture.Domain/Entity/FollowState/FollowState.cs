namespace ASTEK.Architecture.Domain.Entity.FollowState
{
    using ASTEK.Architecture.Infrastructure.Domain;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FollowState")]
    public partial class FollowState: EntityBase<Guid>, IAggregateRoot
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FollowState()
        {
            LessonFolloweds = new HashSet<Domain.Entity.LessonFollowed.LessonFollowed>();
        }

        [Key]
        public Guid FLSCODE { get; set; }

        [Required]
        [StringLength(10)]
        public string FLSWORDING { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Domain.Entity.LessonFollowed.LessonFollowed> LessonFolloweds { get; set; }
    }
}
