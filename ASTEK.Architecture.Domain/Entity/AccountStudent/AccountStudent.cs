namespace ASTEK.Architecture.Domain.Entity.AccountStudent
{
    using FluentValidation.Attributes;
    using Infrastructure.Domain;
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using Validator;

    [Table("AccountStudent")]
    [Validator(typeof(AccountStudentValidator))]
    public partial class AccountStudent: EntityBase<Guid>, IAggregateRoot
    {
        [Key]
        public Guid ACSID { get; set; }

        public Guid ACCID { get; set; }

        public Guid GENCODE { get; set; }

        public Guid STDCODE { get; set; }

        [Required]
        [StringLength(50)]
        public string ACSFIRSTNAME { get; set; }

        [StringLength(50)]
        public string ACSNAME { get; set; }

        public DateTime ACSBIRTHDAY { get; set; }

        public int ACSLEVEL { get; set; }

        [StringLength(50)]
        public string ACSUNIVERSITY { get; set; }

        [ForeignKey("ACCID")]
        public virtual Account.Account Account { get; set; }

        [ForeignKey("GENCODE")]
        public virtual Gender.Gender Gender { get; set; }

        [ForeignKey("STDCODE")]
        public virtual Study.Study Study { get; set; }
    }
}
