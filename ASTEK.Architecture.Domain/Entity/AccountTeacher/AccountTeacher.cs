namespace ASTEK.Architecture.Domain.Entity.AccountTeacher
{
    using FluentValidation.Attributes;
    using Infrastructure.Domain;
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using Validator;

    [Table("AccountTeacher")]
    [Validator(typeof(AccountTeacherValidator))]
    public partial class AccountTeacher: EntityBase<Guid>, IAggregateRoot
    {
        [Key]
        public Guid ACTID { get; set; }

        public Guid ACCID { get; set; }

        public Guid GENCODE { get; set; }

        [Required]
        [StringLength(50)]
        public string ACTFIRSTNAME { get; set; }

        [Required]
        [StringLength(50)]
        public string ACTNAME { get; set; }

        public DateTime ACTBIRTHDAY { get; set; }

        [Required]
        [StringLength(25)]
        public string ACTTOWN { get; set; }

        [Required]
        [Column(Order = 6)]
        public string ACTPOSTALCODE { get; set; }

        [Required]
        [Column(Order = 7)]
        [StringLength(75)]
        public string ACTADDRESS { get; set; }

        [StringLength(100)]
        public string ACTCV { get; set; }

        [ForeignKey("ACCID")]
        public virtual Account.Account Account { get; set; }

        [ForeignKey("GENCODE")]
        public virtual Gender.Gender Gender { get; set; }
    }
}
