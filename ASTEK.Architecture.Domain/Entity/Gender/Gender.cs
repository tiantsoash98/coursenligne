namespace ASTEK.Architecture.Domain.Entity.Gender
{
    using Infrastructure.Domain;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Gender")]
    public partial class Gender: EntityBase<Guid>, IAggregateRoot
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Gender()
        {
            AccountStudents = new HashSet<AccountStudent.AccountStudent>();
            AccountTeachers = new HashSet<AccountTeacher.AccountTeacher>();
            EntityStrings = new HashSet<EntityStrings.EntityStrings>();
        }

        [Key]
        public Guid GENCODE { get; set; }

        [Required]
        [StringLength(25)]
        public string GENWORDING { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AccountStudent.AccountStudent> AccountStudents { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AccountTeacher.AccountTeacher> AccountTeachers { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        [ForeignKey("ESTENTITYID")]
        public virtual ICollection<EntityStrings.EntityStrings> EntityStrings { get; set; }
    }
}
