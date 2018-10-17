namespace ASTEK.Architecture.Domain.Entity.Study
{
    using Infrastructure.Domain;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Study")]
    public partial class Study: EntityBase<Guid>, IAggregateRoot
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Study()
        {
            Curricula = new HashSet<Curriculum>();
            Lessons = new HashSet<Lesson.Lesson>();
            Accounts = new HashSet<Account.Account>();
            EntityStrings = new HashSet<EntityStrings.EntityStrings>();
        }

        [Key]
        public Guid STDCODE { get; set; }

        [Required]
        [StringLength(50)]
        public string STDNAME { get; set; }

        [StringLength(500)]
        public string STDDESCRIPTION { get; set; }

        [StringLength(100)]
        public string STDPICTURE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Curriculum> Curricula { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Lesson.Lesson> Lessons { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Account.Account> Accounts { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        [ForeignKey("ESTENTITYID")]
        public virtual ICollection<EntityStrings.EntityStrings> EntityStrings { get; set; }
    }
}
