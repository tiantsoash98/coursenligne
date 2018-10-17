namespace ASTEK.Architecture.Domain.Entity.EntityStrings
{
    using ASTEK.Architecture.Infrastructure.Domain;
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class EntityStrings : EntityBase<Guid>, IAggregateRoot
    {
        [Key]
        [Column(Order = 0)]
        public Guid ESTENTITYID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(200)]
        public string CLTCODE { get; set; } 


        [Column(Order = 2)]
        [StringLength(200)]
        public string ESTWORDING { get; set; }

        [ForeignKey("CLTCODE")]
        public virtual Culture.Culture Culture { get; set; }
    }
}
