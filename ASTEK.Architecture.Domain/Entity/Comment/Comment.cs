namespace ASTEK.Architecture.Domain.Entity.Comment
{
    using ASTEK.Architecture.Infrastructure.Domain;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Comment")]
    public partial class Comment: EntityBase<Guid>, IAggregateRoot
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Comment()
        {
            CommentAnswers = new HashSet<CommentAnswer.CommentAnswer>();
        }

        [Key]
        public Guid COMID { get; set; }

        public Guid LSNID { get; set; }

        public Guid ACCID { get; set; }

        public Guid DCSCODE { get; set; }

        public DateTime COMDATE { get; set; }

        [Required]
        [StringLength(2000)]
        public string COMCONTENT { get; set; }

        [ForeignKey("ACCID")]
        public virtual Account.Account Account { get; set; }

        [ForeignKey("DCSCODE")]
        public virtual DocumentState.DocumentState DocumentState { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CommentAnswer.CommentAnswer> CommentAnswers { get; set; }
    }
}
