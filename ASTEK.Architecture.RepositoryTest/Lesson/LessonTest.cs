using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ASTEK.Architecture.Repository;
using ASTEK.Architecture.Repository.Concrete;
using System.Collections.Generic;
using System.Linq;
using ASTEK.Architecture.Infrastructure.Navigation;
using ASTEK.Architecture.Infrastructure.Specification;
using System.Linq.Expressions;

namespace ASTEK.Architecture.RepositoryTest.Lesson
{
    [TestClass]
    public class LessonTest
    {
        [TestMethod]
        public void Insert()
        {
            var lesson = new Domain.Entity.Lesson.Lesson()
            {
                STDCODE = new Guid("F79B7A04-1EA1-E811-8221-2C600C6934BE"),
                ACCID = new Guid("9AB7771D-F69F-E811-8220-2C600C6934BE"),
                DCFCODE = new Guid("7CCAF4E2-CF9E-E811-8220-2C600C6934BE"),
                LSNTITLE = "Développer des applications en Python",
                LSNDATE = DateTime.Now,
                LSNDESCRIPTION = "Grâce à la spécialisation Python / Django, vous saurez construire des scripts et des applications web robustes. Vous découvrirez les sujets centraux du développement web et serez capable, entre autre, de lancer un programme en ligne de commande. Les bases de données, les bonnes pratiques en Python ou les serveurs n''auront plus de secrets pour vous ! ",
                LSNTARGET = "<ul><li>Créer des projets web dynamiques grâce à Python</li><li>Utiliser les outils les plus connus d''intégration continue</li></ul>",
                LSNDURATION = 90000000000
            };


            EFDbContext context = new EFDbContext();
            EFLessonRepository rep = new EFLessonRepository(context);
            rep.Add(lesson);
        }

        [TestMethod]
        public void GetTeacherName()
        {
            var context = new EFDbContext();

            var lesson = new EFLessonRepository(context).FindBy(new Guid("7cce715f-f7a1-e811-8221-2c600c6934be"));

            Console.WriteLine(lesson.Account.AccountTeachers.First().ACTFIRSTNAME);
            Assert.AreEqual("prof1@itu.local", lesson.Account.ACCEMAIL);
        }

        [TestMethod]
        public void GetChapterCountLessonId()
        {
            var id = new Guid("7CCE715F-F7A1-E811-8221-2C600C6934BE");

            var context = new EFDbContext();
            var rep = new EFLessonRepository(context);

            int count = rep.GetChapterCount(id);

            Assert.AreEqual(0, count);
        }

        [TestMethod]
        public void GetChapterCountLessonFindBy()
        {
            var id = new Guid("7CCE715F-F7A1-E811-8221-2C600C6934BE");

            var context = new EFDbContext();
            var rep = new EFLessonRepository(context);

            var lesson = rep.FindBy(id);

            int count = rep.GetChapterCount(lesson);

            Assert.AreEqual(0, count);
        }

        [TestMethod]
        public void GetExerciceCountLessonId()
        {
            var id = new Guid("7CCE715F-F7A1-E811-8221-2C600C6934BE");

            var context = new EFDbContext();
            var rep = new EFLessonRepository(context);

            int count = rep.GetExerciceCount(id);

            Assert.AreEqual(0, count);
        }

        [TestMethod]
        public void GetExerciceCountLesson()
        {
            var id = new Guid("7CCE715F-F7A1-E811-8221-2C600C6934BE");

            var context = new EFDbContext();
            var rep = new EFLessonRepository(context);

            var lesson = rep.FindBy(id);

            int count = rep.GetExerciceCount(lesson);

            Assert.AreEqual(0, count);
        }

        [TestMethod]
        public void GetLessonNavigation()
        {
            var id = new Guid("8BA35141-85BA-E811-8225-2C600C6934BE");

            var context = new EFDbContext();
            var rep = new EFLessonRepository(context);

            LessonNavigation navigation = rep.GetLessonNavigation(id);


            navigation.Chapters.ForEach(x =>
            {
                Console.WriteLine(x.Number + ". " + x.Title);

                x.Parts.ForEach(p =>
                {
                    Console.WriteLine("\t" + p.Number + ". " + p.Title);
                });
            });
        }

        [TestMethod]
        public void GetLessonNavigationCountTotalElements()
        {
            var id = new Guid("7CCE715F-F7A1-E811-8221-2C600C6934BE");

            var context = new EFDbContext();
            var rep = new EFLessonRepository(context);

            LessonNavigation navigation = rep.GetLessonNavigation(id);


            navigation.Chapters.ForEach(x =>
            {
                Console.WriteLine(x.Number + ". " + x.Title);

                x.Parts.ForEach(p =>
                {
                    Console.WriteLine("\t" + p.Number + ". " + p.Title);
                });
            });

            int totalElements = navigation.CountTotalElements();
            int totalAt = navigation.CountTotalElements(2, 1);
            double pourcentage = (totalAt / (double)totalElements) * 100;

            Console.WriteLine("\nElements: " + totalElements);
            Console.WriteLine("\nElements at: " + totalAt);
            Console.WriteLine("\nPourcentage: " + pourcentage + "%");
        }

        [TestMethod]
        public void GetBestByStudy()
        {
            var id = new Guid("8CDE8A70-9B9C-E811-8220-2C600C6934BE");

            var context = new EFDbContext();
            var rep = new EFLessonRepository(context);

            List<Domain.Entity.Lesson.Lesson> studies = rep.GetBestByStudy(id);


            studies.ForEach(x =>
            {
                Console.WriteLine(x.LSNTITLE);
            });
        }

        [TestMethod]
        public void Update()
        {
            var context = new EFDbContext();
            var rep = new EFLessonRepository(context);

            var id = new Guid("6B751675-6FB2-E811-8222-2C600C6934BE");

            var lesson = new Domain.Entity.Lesson.Lesson
            {
                DCFCODE = new Guid("7CCAF4E2-CF9E-E811-8220-2C600C6934BE"),
                LSNDESCRIPTION = "Modif description réussie!!!!",
                STDCODE = new Guid("F79B7A04-1EA1-E811-8221-2C600C6934BE"),
                LSNTARGET = "vvvvvvvvvvv",
                LSNTITLE = "aadsqdsqdlkjl"
            };

            rep.Update(id, lesson);
        }
    }
}
