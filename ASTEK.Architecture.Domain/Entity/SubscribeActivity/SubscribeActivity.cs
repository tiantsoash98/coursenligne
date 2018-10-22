namespace ASTEK.Architecture.Domain.Entity.SubscribeActivity
{
    using ASTEK.Architecture.Infrastructure.Domain;
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("SubscribeActivity")]
    public partial class SubscribeActivity : EntityBase<Guid>, IAggregateRoot
    {
        [Key]
        public Guid SUBID { get; set; }

        public Guid ACCSUBSCRIBER { get; set; }

        public Guid ACCSUBSCRIBED { get; set; }

        public DateTime SUBDATE { get; set; }

        [ForeignKey("ACCSUBSCRIBER")]
        public virtual Account.Account Subscriber { get; set; }

        [ForeignKey("ACCSUBSCRIBED")]
        public virtual Account.Account Subscribed { get; set; }
    }
}
