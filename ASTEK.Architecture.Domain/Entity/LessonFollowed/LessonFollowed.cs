namespace ASTEK.Architecture.Domain.Entity.LessonFollowed
{
    using ASTEK.Architecture.Infrastructure.Domain;
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("LessonFollowed")]
    public partial class LessonFollowed: EntityBase<Guid>, IAggregateRoot
    {
        [Key]
        [Column(Order = 0)]
        public Guid ACCID { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid LSNID { get; set; }

        public Guid FLSCODE { get; set; }

        public DateTime LSFDATE { get; set; }

        public short? LSFCHAPTER { get; set; }

        public short? LSFPART { get; set; }

        [ForeignKey("ACCID")]
        public virtual Domain.Entity.Account.Account Account { get; set; }

        [ForeignKey("LSNID")]
        public virtual Lesson.Lesson Lesson { get; set; }

        [ForeignKey("FLSCODE")]
        public virtual FollowState.FollowState FollowState { get; set; }
    }
}
