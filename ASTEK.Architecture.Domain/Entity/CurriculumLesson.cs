namespace ASTEK.Architecture.Domain.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CurriculumLesson
    {
        [Key]
        [Column(Order = 0)]
        public Guid LSNID { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid CURID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal CLSCREDIT { get; set; }

        public virtual Curriculum Curriculum { get; set; }

        public virtual Lesson.Lesson Lesson { get; set; }
    }
}
