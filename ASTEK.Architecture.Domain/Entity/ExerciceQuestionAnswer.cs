namespace ASTEK.Architecture.Domain.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ExerciceQuestionAnswer")]
    public partial class ExerciceQuestionAnswer
    {
        [Key]
        [Column(Order = 0)]
        public Guid EXDID { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid EXQCODE { get; set; }

        [StringLength(1000)]
        public string EQAVALUE { get; set; }

        public virtual ExerciceDone ExerciceDone { get; set; }

        public virtual ExerciceQuestion ExerciceQuestion { get; set; }
    }
}
