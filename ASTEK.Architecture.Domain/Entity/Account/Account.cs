namespace ASTEK.Architecture.Domain.Entity.Account
{
    using FluentValidation.Attributes;
    using Infrastructure.Domain;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using Validator;

    [Table("Account")]
    [Validator(typeof(AccountValidator))]
    public partial class Account: EntityBase<Guid>, IAggregateRoot
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Account()
        {
            AccountStudents = new HashSet<AccountStudent.AccountStudent>();
            AccountTeachers = new HashSet<AccountTeacher.AccountTeacher>();
            CurriculumSubscriptions = new HashSet<CurriculumSubscription>();
            ExerciceDones = new HashSet<ExerciceDone>();
            ExerciceCorrections = new HashSet<ExerciceCorrection>();
            Lessons = new HashSet<Lesson.Lesson>();
            LessonFolloweds = new HashSet<LessonFollowed.LessonFollowed>();
            Studies = new HashSet<Study.Study>();
            AnswerExercices = new HashSet<AnswerExercice.AnswerExercice>();
        }

        [Key]
        public Guid ACCID { get; set; }

        public Guid CTRCODE { get; set; }

        public Guid ATPCODE { get; set; }

        [Required]
        [StringLength(50)]
        public string ACCEMAIL { get; set; }

        [StringLength(255)]
        public string ACCPASSWORD { get; set; }

        [StringLength(20)]
        public string ACCPHONECONTACT { get; set; }

        [StringLength(100)]
        public string ACCPICTURE { get; set; }

        public DateTime ACCINSCRIPTIONDATE { get; set; }

        public virtual Country.Country Country { get; set; }

        public virtual AccountType AccountType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AccountStudent.AccountStudent> AccountStudents { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AccountTeacher.AccountTeacher> AccountTeachers { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CurriculumSubscription> CurriculumSubscriptions { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ExerciceDone> ExerciceDones { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ExerciceCorrection> ExerciceCorrections { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Lesson.Lesson> Lessons { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LessonFollowed.LessonFollowed> LessonFolloweds { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Study.Study> Studies { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AnswerExercice.AnswerExercice> AnswerExercices { get; set; }
    }
}
