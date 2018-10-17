using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace ASTEK.Architecture.Repository
{
    public class TableConfiguration
    {
        #region AccountConfiguration
        public class AccountConfiguration : EntityTypeConfiguration<Domain.Entity.Account.Account>
        {
            public AccountConfiguration()
            {
                HasKey(e => e.Id);

                Property(e => e.Id)
                    .HasColumnName("ACCID");

                Property(e => e.Id)
                    .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

                Ignore(e => e.ACCID);

                Ignore(e => e.DateCreation);

                Ignore(e => e.IsDeleted);

                Property(e => e.ACCEMAIL)
                     .IsUnicode(false);

                Property(e => e.ACCPASSWORD)
                     .IsUnicode(false);

                Property(e => e.ACCPHONECONTACT)
                     .IsUnicode(false);

                HasMany(e => e.AccountStudents)
                     .WithRequired(e => e.Account)
                     .WillCascadeOnDelete(false);

                HasMany(e => e.AccountTeachers)
                     .WithRequired(e => e.Account)
                     .WillCascadeOnDelete(false);


                HasMany(e => e.CurriculumSubscriptions)
                     .WithRequired(e => e.Account)
                     .WillCascadeOnDelete(false);


                HasMany(e => e.ExerciceDones)
                     .WithRequired(e => e.Account)
                     .WillCascadeOnDelete(false);


                HasMany(e => e.ExerciceCorrections)
                     .WithRequired(e => e.Account)
                     .WillCascadeOnDelete(false);

                HasMany(e => e.Lessons)
                     .WithRequired(e => e.Account)
                     .WillCascadeOnDelete(false);


                HasMany(e => e.LessonFolloweds)
                     .WithRequired(e => e.Account)
                     .WillCascadeOnDelete(false);


                HasMany(e => e.Studies)
                     .WithMany(e => e.Accounts)
                     .Map(m => m.ToTable("AccountStudy").MapLeftKey("ACCID").MapRightKey("STDCODE"));
            }
        }

        #endregion

        #region CountryConfiguration
        public class CountryConfiguration : EntityTypeConfiguration<Domain.Entity.Country.Country>
        {
            public CountryConfiguration()
            {
                HasKey(e => e.CTRCODE);

                Property(e => e.CTRCODE)
                    .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

                Ignore(e => e.Id);

                Ignore(e => e.DateCreation);

                Ignore(e => e.IsDeleted);

                Property(e => e.CTRNAME).IsUnicode(false);

                HasMany(e => e.Accounts)
                    .WithRequired(e => e.Country)
                    .WillCascadeOnDelete(false);
            }
        }
        #endregion

        #region CultureConfiguration
        public class CultureConfiguration : EntityTypeConfiguration<Domain.Entity.Culture.Culture>
        {
            public CultureConfiguration()
            {
                HasKey(e => e.CLTCODE);

                Property(e => e.CLTCODE)
                    .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

                Ignore(e => e.Id);

                Ignore(e => e.DateCreation);

                Ignore(e => e.IsDeleted);

                Property(e => e.CLTWORDING)
                    .IsUnicode(false);

                HasMany(e => e.EntityStrings)
                    .WithRequired(e => e.Culture)
                    .WillCascadeOnDelete(false);
            }
        }
        #endregion

        #region AccountStudentConfiguration
        public class AccountStudentConfiguration : EntityTypeConfiguration<Domain.Entity.AccountStudent.AccountStudent>
        {
            public AccountStudentConfiguration()
            {
                HasKey(e => e.Id);

                Property(e => e.Id)
                    .HasColumnName("ACSID");

                Property(e => e.Id)
                    .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

                Ignore(e => e.ACSID);

                Ignore(e => e.DateCreation);

                Ignore(e => e.IsDeleted);

                Property(e => e.ACSFIRSTNAME).IsUnicode(false);

                Property(e => e.ACSNAME).IsUnicode(false);
            }
        }
        #endregion

        #region AccountTeacherConfiguration
        public class AccountTeacherConfiguration : EntityTypeConfiguration<Domain.Entity.AccountTeacher.AccountTeacher>
        {
            public AccountTeacherConfiguration()
            {
                HasKey(e => e.Id);

                Property(e => e.Id)
                    .HasColumnName("ACTID");

                Property(e => e.Id)
                    .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

                Ignore(e => e.ACTID);

                Ignore(e => e.DateCreation);

                Ignore(e => e.IsDeleted);

                Property(e => e.ACTFIRSTNAME).IsUnicode(false);

                Property(e => e.ACTNAME).IsUnicode(false);

                Property(e => e.ACTTOWN).IsUnicode(false);

                Property(e => e.ACTADDRESS).IsUnicode(false);

                Property(e => e.ACTCV).IsUnicode(false);
            }
        }
        #endregion

        #region EntityStringsConfiguration
        public class EntityStringsConfiguration : EntityTypeConfiguration<Domain.Entity.EntityStrings.EntityStrings>
        {
            public EntityStringsConfiguration()
            {
                Ignore(e => e.Id);

                Ignore(e => e.DateCreation);

                Ignore(e => e.IsDeleted);

                Property(e => e.CLTCODE)
                    .IsUnicode(false);

                Property(e => e.ESTWORDING)
                    .IsUnicode(false);
            }
        }
        #endregion

        #region FollowStateConfiguration
        public class FollowStateConfiguration : EntityTypeConfiguration<Domain.Entity.FollowState.FollowState>
        {
            public FollowStateConfiguration()
            {
                HasKey(e => e.FLSCODE);

                Property(e => e.FLSCODE)
                    .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

                Ignore(e => e.Id);

                Ignore(e => e.DateCreation);

                Ignore(e => e.IsDeleted);


                Property(e => e.FLSWORDING)
                    .IsFixedLength()
                    .IsUnicode(false);

                HasMany(e => e.LessonFolloweds)
                    .WithRequired(e => e.FollowState)
                    .WillCascadeOnDelete(false);
            }
        }
        #endregion

        #region GenderConfiguration
        public class GenderConfiguration : EntityTypeConfiguration<Domain.Entity.Gender.Gender>
        {
            public GenderConfiguration()
            {
                HasKey(e => e.GENCODE);

                Property(e => e.GENCODE)
                    .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

                Ignore(e => e.Id);

                Ignore(e => e.DateCreation);

                Ignore(e => e.IsDeleted);

                Property(e => e.GENWORDING)
                .IsUnicode(false);

                HasMany(e => e.AccountStudents)
                .WithRequired(e => e.Gender)
                .WillCascadeOnDelete(false);

                HasMany(e => e.AccountTeachers)
                .WithRequired(e => e.Gender)
                .WillCascadeOnDelete(false);
            }
        }
        #endregion

        #region StudyConfiguration
        public class StudyConfiguration : EntityTypeConfiguration<Domain.Entity.Study.Study>
        {
            public StudyConfiguration()
            {
                HasKey(e => e.STDCODE);

                Property(e => e.STDCODE)
                    .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

                Ignore(e => e.Id);

                Ignore(e => e.DateCreation);

                Ignore(e => e.IsDeleted);

                Property(e => e.STDNAME)
                .IsUnicode(false);

                Property(e => e.STDDESCRIPTION)
                    .IsUnicode(false);

                HasMany(e => e.Curricula)
                    .WithRequired(e => e.Study)
                    .WillCascadeOnDelete(false);
            }
        }
        #endregion

        #region DocumentConfidentialityConfiguration
        public class DocumentConfidentialityConfiguration : EntityTypeConfiguration<Domain.Entity.DocumentConfidentiality.DocumentConfidentiality>
        {
            public DocumentConfidentialityConfiguration()
            {
                HasKey(e => e.DCFCODE);

                Property(e => e.DCFCODE)
                    .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

                Ignore(e => e.Id);

                Ignore(e => e.DateCreation);

                Ignore(e => e.IsDeleted);

                Property(e => e.DCFWORDING)
                    .IsUnicode(false);

                HasMany(e => e.Lessons)
                    .WithRequired(e => e.DocumentConfidentiality)
                    .WillCascadeOnDelete(false);
            }
        }
        #endregion

        #region DocumentStateConfiguration
        public class DocumentStateConfiguration : EntityTypeConfiguration<Domain.Entity.DocumentState.DocumentState>
        {
            public DocumentStateConfiguration()
            {
                HasKey(e => e.DCSCODE);

                Property(e => e.DCSCODE)
                    .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

                Ignore(e => e.Id);

                Ignore(e => e.DateCreation);

                Ignore(e => e.IsDeleted);

                Property(e => e.DCSWORDING)
                    .IsUnicode(false);

                HasMany(e => e.Lessons)
                    .WithRequired(e => e.DocumentState)
                    .WillCascadeOnDelete(false);
            }
        }
        #endregion

        #region LessonConfiguration
        public class LessonConfiguration : EntityTypeConfiguration<Domain.Entity.Lesson.Lesson>
        {
            public LessonConfiguration()
            {
                HasKey(e => e.Id);

                Property(e => e.Id)
                    .HasColumnName("LSNID");

                Property(e => e.Id)
                    .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

                Ignore(e => e.LSNID);

                Ignore(e => e.DateCreation);

                Ignore(e => e.IsDeleted);

                Property(e => e.LSNTITLE)
                    .IsUnicode(false);

                Property(e => e.LSNDESCRIPTION)
                    .IsUnicode(false);

                Property(e => e.LSNTARGET)
                    .IsUnicode(false);

                HasMany(e => e.CurriculumLessons)
                    .WithRequired(e => e.Lesson)
                    .WillCascadeOnDelete(false);

                HasMany(e => e.Exercices)
                    .WithRequired(e => e.Lesson)
                    .WillCascadeOnDelete(false);

                HasMany(e => e.LessonChapters)
                    .WithRequired(e => e.Lesson)
                    .WillCascadeOnDelete(false);

                HasMany(e => e.LessonFolloweds)
                    .WithRequired(e => e.Lesson)
                    .WillCascadeOnDelete(false);
            }
        }
        #endregion

        #region LessonChapterConfiguration
        public class LessonChapterConfiguration : EntityTypeConfiguration<Domain.Entity.LessonChapter.LessonChapter>
        {
            public LessonChapterConfiguration()
            {
                HasKey(e => e.LSCCODE);

                Property(e => e.LSCCODE)
                    .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

                Ignore(e => e.Id);

                Ignore(e => e.DateCreation);

                Ignore(e => e.IsDeleted);

                Property(e => e.LSCTITLE)
                    .IsUnicode(false);

                Property(e => e.LSCDESCRIPTION)
                    .IsUnicode(false);

                Property(e => e.LSCCONTENT)
                    .IsUnicode(false);

                HasMany(e => e.LessonParts)
                    .WithRequired(e => e.LessonChapter)
                    .WillCascadeOnDelete(false);
            }
        }
        #endregion

        #region LessonPartConfiguration
        public class LessonPartConfiguration : EntityTypeConfiguration<Domain.Entity.LessonPart.LessonPart>
        {
            public LessonPartConfiguration()
            {
                HasKey(e => e.LSPCODE);

                Property(e => e.LSPCODE)
                    .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

                Ignore(e => e.Id);

                Ignore(e => e.DateCreation);

                Ignore(e => e.IsDeleted);

                Property(e => e.LSPTITLE)
                    .IsUnicode(false);

                Property(e => e.LSPCONTENT)
                    .IsUnicode(false);
            }
        }
        #endregion

        #region LessonFollowedConfiguration
        public class LessonFollowedConfiguration : EntityTypeConfiguration<Domain.Entity.LessonFollowed.LessonFollowed>
        {
            public LessonFollowedConfiguration()
            {
                HasKey(e => new { e.ACCID, e.LSNID });

                Ignore(e => e.Id);

                Ignore(e => e.DateCreation);

                Ignore(e => e.IsDeleted);
            }
        }
        #endregion

        #region ExerciceConfiguration
        public class ExerciceConfiguration : EntityTypeConfiguration<Domain.Entity.Exercice.Exercice>
        {
            public ExerciceConfiguration()
            {
                HasKey(e => e.Id);

                Property(e => e.Id)
                    .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

                Ignore(e => e.EXCID);

                Ignore(e => e.DateCreation);

                Ignore(e => e.IsDeleted);

                Property(e => e.EXCTITLE)
                    .IsUnicode(false);

                Property(e => e.EXCDESCRIPTION)
                    .IsUnicode(false);

                Property(e => e.EXCCOMMENT)
                    .IsUnicode(false);

                HasMany(e => e.ExerciceDones)
                    .WithRequired(e => e.Exercice)
                    .WillCascadeOnDelete(false);

                HasMany(e => e.ExerciceQuestions)
                    .WithRequired(e => e.Exercice)
                    .WillCascadeOnDelete(false);
            }
        }   
        #endregion
    }
}