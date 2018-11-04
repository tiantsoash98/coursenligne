namespace ASTEK.Architecture.Repository
{
    using Domain.Entity;
    using Infrastructure.UnitOfWork;
    using System.Data.Entity;

    public partial class EFDbContext : DbContext, IUnitOfWork
    {
        public EFDbContext()
            : base("name=EFDbContext")
        {
        }

        public virtual DbSet<Domain.Entity.Account.Account> Accounts { get; set; }
        public virtual DbSet<AccountType> AccountTypes { get; set; }
        public virtual DbSet<Domain.Entity.AnswerExercice.AnswerExercice> AnswerExercices  { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Domain.Entity.Comment.Comment> Comments { get; set; }
        public virtual DbSet<Domain.Entity.CommentAnswer.CommentAnswer> CommentAnswers { get; set; }
        public virtual DbSet<Domain.Entity.Country.Country> Countries { get; set; }
        public virtual DbSet<Domain.Entity.Culture.Culture> Cultures { get; set; }
        public virtual DbSet<Curriculum> Curricula { get; set; }
        public virtual DbSet<CurriculumLesson> CurriculumLessons { get; set; }
        public virtual DbSet<CurriculumSubscription> CurriculumSubscriptions { get; set; }
        public virtual DbSet<Domain.Entity.DocumentConfidentiality.DocumentConfidentiality> DocumentConfidentialities { get; set; }
        public virtual DbSet<Domain.Entity.DocumentState.DocumentState> DocumentStates { get; set; }
        public virtual DbSet<Domain.Entity.EntityStrings.EntityStrings> EntityStrings { get; set; }
        public virtual DbSet<Domain.Entity.Exercice.Exercice> Exercices { get; set; }
        public virtual DbSet<ExerciceCorrection> ExerciceCorrections { get; set; }
        public virtual DbSet<ExerciceDone> ExerciceDones { get; set; }
        public virtual DbSet<ExerciceQuestion> ExerciceQuestions { get; set; }
        public virtual DbSet<ExerciceQuestionAnswer> ExerciceQuestionAnswers { get; set; }
        public virtual DbSet<ExerciceQuestionChoice> ExerciceQuestionChoices { get; set; }
        public virtual DbSet<ExerciceQuestionType> ExerciceQuestionTypes { get; set; }
        public virtual DbSet<FieldType> FieldTypes { get; set; }
        public virtual DbSet<Domain.Entity.FollowState.FollowState> FollowStates { get; set; }
        public virtual DbSet<Domain.Entity.Gender.Gender> Genders { get; set; }
        public virtual DbSet<Domain.Entity.Lesson.Lesson> Lessons { get; set; }
        public virtual DbSet<Domain.Entity.LessonChapter.LessonChapter> LessonChapters { get; set; }
        public virtual DbSet<Domain.Entity.LessonFollowed.LessonFollowed> LessonFolloweds { get; set; }
        public virtual DbSet<Domain.Entity.Study.Study> Studies { get; set; }
        public virtual DbSet<Domain.Entity.AccountStudent.AccountStudent> AccountStudents { get; set; }
        public virtual DbSet<Domain.Entity.AccountTeacher.AccountTeacher> AccountTeachers { get; set; }
        public virtual DbSet<Domain.Entity.LessonPart.LessonPart> LessonParts { get; set; }
        public virtual DbSet<Domain.Entity.SubscribeActivity.SubscribeActivity> SubscribeActivities { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new TableConfiguration.AccountConfiguration());
            modelBuilder.Configurations.Add(new TableConfiguration.CountryConfiguration());
            modelBuilder.Configurations.Add(new TableConfiguration.AccountStudentConfiguration());
            modelBuilder.Configurations.Add(new TableConfiguration.CultureConfiguration());
            modelBuilder.Configurations.Add(new TableConfiguration.EntityStringsConfiguration());
            modelBuilder.Configurations.Add(new TableConfiguration.AccountTeacherConfiguration());
            modelBuilder.Configurations.Add(new TableConfiguration.FollowStateConfiguration());
            modelBuilder.Configurations.Add(new TableConfiguration.GenderConfiguration());
            modelBuilder.Configurations.Add(new TableConfiguration.SubscribeActivityConfiguration());
            modelBuilder.Configurations.Add(new TableConfiguration.StudyConfiguration());
            modelBuilder.Configurations.Add(new TableConfiguration.DocumentConfidentialityConfiguration());
            modelBuilder.Configurations.Add(new TableConfiguration.DocumentStateConfiguration());
            modelBuilder.Configurations.Add(new TableConfiguration.LessonConfiguration());
            modelBuilder.Configurations.Add(new TableConfiguration.LessonChapterConfiguration());
            modelBuilder.Configurations.Add(new TableConfiguration.LessonPartConfiguration());
            modelBuilder.Configurations.Add(new TableConfiguration.LessonFollowedConfiguration());
            modelBuilder.Configurations.Add(new TableConfiguration.ExerciceConfiguration());
            modelBuilder.Configurations.Add(new TableConfiguration.CommentConfiguration());
            modelBuilder.Configurations.Add(new TableConfiguration.CommentAnswerConfiguration());
            modelBuilder.Configurations.Add(new TableConfiguration.AnswerExerciceConfiguration());


            modelBuilder.Entity<AccountType>()
                .Property(e => e.ATPWORDING)
                .IsUnicode(false);

            modelBuilder.Entity<AccountType>()
                .HasMany(e => e.Accounts)
                .WithRequired(e => e.AccountType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Category>()
                .Property(e => e.CTGNAME)
                .IsUnicode(false);

            modelBuilder.Entity<Category>()
                .Property(e => e.CTGDESCRIPTION)
                .IsUnicode(false);

            modelBuilder.Entity<Category>()
                .HasMany(e => e.Curricula)
                .WithMany(e => e.Categories)
                .Map(m => m.ToTable("CurriculumCategory").MapLeftKey("CTGID").MapRightKey("CURID"));
        

            modelBuilder.Entity<Curriculum>()
                .Property(e => e.CURNAME)
                .IsUnicode(false);

            modelBuilder.Entity<Curriculum>()
                .Property(e => e.CURDESCRIPTION)
                .IsUnicode(false);

            modelBuilder.Entity<Curriculum>()
                .Property(e => e.CURCREDIT)
                .HasPrecision(5, 2);

            modelBuilder.Entity<Curriculum>()
                .Property(e => e.CURLEVELMIN)
                .IsUnicode(false);

            modelBuilder.Entity<Curriculum>()
                .HasMany(e => e.CurriculumSubscriptions)
                .WithRequired(e => e.Curriculum)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Curriculum>()
                .HasMany(e => e.CurriculumLessons)
                .WithRequired(e => e.Curriculum)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CurriculumLesson>()
                .Property(e => e.CLSCREDIT)
                .HasPrecision(5, 2);

            modelBuilder.Entity<ExerciceCorrection>()
                .Property(e => e.ECRAPOINTS)
                .HasPrecision(5, 2);

            modelBuilder.Entity<ExerciceDone>()
                .Property(e => e.EXDCOMMENT)
                .IsUnicode(false);

            modelBuilder.Entity<ExerciceDone>()
                .HasMany(e => e.ExerciceCorrections)
                .WithRequired(e => e.ExerciceDone)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ExerciceDone>()
                .HasMany(e => e.ExerciceQuestionAnswers)
                .WithRequired(e => e.ExerciceDone)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ExerciceQuestion>()
                .Property(e => e.EXQQUESTION)
                .IsUnicode(false);

            modelBuilder.Entity<ExerciceQuestion>()
                .Property(e => e.EXQANSWER)
                .IsUnicode(false);

            modelBuilder.Entity<ExerciceQuestion>()
                .Property(e => e.EXQPOINTS)
                .HasPrecision(5, 2);

            modelBuilder.Entity<ExerciceQuestion>()
                .HasMany(e => e.ExerciceQuestionAnswers)
                .WithRequired(e => e.ExerciceQuestion)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ExerciceQuestionAnswer>()
                .Property(e => e.EQAVALUE)
                .IsUnicode(false);

            modelBuilder.Entity<ExerciceQuestionChoice>()
                .Property(e => e.EQCANWSER)
                .IsUnicode(false);

            modelBuilder.Entity<ExerciceQuestionType>()
                .Property(e => e.EQTWORDING)
                .IsUnicode(false);

            modelBuilder.Entity<ExerciceQuestionType>()
                .HasMany(e => e.ExerciceQuestions)
                .WithRequired(e => e.ExerciceQuestionType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FieldType>()
                .Property(e => e.FLDWORDING)
                .IsUnicode(false);        
        }

        void IUnitOfWork.SaveChanges()
        {
            base.SaveChanges();
        }
    }
}
