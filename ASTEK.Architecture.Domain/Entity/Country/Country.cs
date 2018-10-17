namespace ASTEK.Architecture.Domain.Entity.Country
{
    using Infrastructure.Domain;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Country")]
    public partial class Country: EntityBase<Guid>, IAggregateRoot
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Country()
        {
            Accounts = new HashSet<Domain.Entity.Account.Account>();
        }

        [Key]
        public Guid CTRCODE { get; set; }

        [Required]
        [StringLength(50)]
        public string CTRNAME { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Domain.Entity.Account.Account> Accounts { get; set; }
    }
}
