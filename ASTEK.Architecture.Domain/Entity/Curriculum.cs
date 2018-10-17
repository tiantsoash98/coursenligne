namespace ASTEK.Architecture.Domain.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Curriculum")]
    public partial class Curriculum
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Curriculum()
        {
            CurriculumSubscriptions = new HashSet<CurriculumSubscription>();
            CurriculumLessons = new HashSet<CurriculumLesson>();
            Categories = new HashSet<Category>();
        }

        [Key]
        public Guid CURID { get; set; }

        public Guid STDCODE { get; set; }

        [Required]
        [StringLength(50)]
        public string CURNAME { get; set; }

        [Required]
        [StringLength(500)]
        public string CURDESCRIPTION { get; set; }
     
        [Column(TypeName = "numeric")]
        public decimal? CURCREDIT { get; set; }

        [StringLength(500)]
        public string CURLEVELMIN { get; set; }

        public long? CURDURATION { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CurriculumSubscription> CurriculumSubscriptions { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CurriculumLesson> CurriculumLessons { get; set; }

        public virtual Study.Study Study { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Category> Categories { get; set; }
    }
}
