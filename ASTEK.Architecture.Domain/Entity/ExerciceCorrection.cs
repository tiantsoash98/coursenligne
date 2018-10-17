namespace ASTEK.Architecture.Domain.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ExerciceCorrection")]
    public partial class ExerciceCorrection
    {
        [Key]
        [Column(Order = 0)]
        public Guid ACCID { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid EXDID { get; set; }

        public DateTime ECRDATE { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ECRAPOINTS { get; set; }

        public virtual Domain.Entity.Account.Account Account { get; set; }

        public virtual ExerciceDone ExerciceDone { get; set; }
    }
}
