namespace ASTEK.Architecture.Domain.Entity.CommentAnswer
{
    using ASTEK.Architecture.Domain.Validator;
    using ASTEK.Architecture.Infrastructure.Domain;
    using FluentValidation.Attributes;
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("CommentAnswer")]
    [Validator(typeof(AccountValidator))]
    public partial class CommentAnswer: EntityBase<Guid>, IAggregateRoot
    {
        [Key]
        public Guid CANID { get; set; }

        public Guid COMID { get; set; }

        public Guid DCSCODE { get; set; }

        public Guid ACCID { get; set; }

        public DateTime CANDATE { get; set; }

        [Required]
        [StringLength(1000)]
        public string CANCONTENT { get; set; }

        [ForeignKey("ACCID")]
        public virtual Account.Account Account { get; set; }

        [ForeignKey("DCSCODE")]
        public virtual DocumentState.DocumentState DocumentState { get; set; }

        [ForeignKey("COMID")]
        public virtual Comment.Comment Comment { get; set; }
    }
}
