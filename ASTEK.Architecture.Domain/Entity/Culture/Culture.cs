namespace ASTEK.Architecture.Domain.Entity.Culture
{
    using ASTEK.Architecture.Infrastructure.Domain;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Culture")]
    public partial class Culture: EntityBase<Guid>, IAggregateRoot
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Culture()
        {
            EntityStrings = new HashSet<EntityStrings.EntityStrings>();
        }

        [Key]
        [StringLength(200)]
        public string CLTCODE { get; set; }

        [Required]
        [StringLength(25)]
        public string CLTWORDING { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EntityStrings.EntityStrings> EntityStrings { get; set; }
    }
}
