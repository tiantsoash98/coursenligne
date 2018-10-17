namespace ASTEK.Architecture.Domain.Entity
{
    using Infrastructure.Domain;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CurriculumSubscription")]
    public partial class CurriculumSubscription: IAggregateRoot
    {
        [Key]
        [Column(Order = 0)]
        public Guid ACCID { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid CURID { get; set; }

        public DateTime CSBDATE { get; set; }

        public virtual Domain.Entity.Account.Account Account { get; set; }

        public virtual Curriculum Curriculum { get; set; }
    }
}
