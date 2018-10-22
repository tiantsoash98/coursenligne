namespace ASTEK.Architecture.Domain.Entity.TeacherFollowed
{
    using Infrastructure.Domain;
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("TeacherFollowed")]
    public partial class AccountFollowed: EntityBase<Guid>, IAggregateRoot
    {
        public Guid ACCID { get; set; }

        public Guid ACFFOLLOWED { get; set; }

        public DateTime ACFDATE { get; set; }
    }
}
