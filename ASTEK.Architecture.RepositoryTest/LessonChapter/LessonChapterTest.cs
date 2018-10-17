using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ASTEK.Architecture.Repository;
using ASTEK.Architecture.Repository.Concrete;

namespace ASTEK.Architecture.RepositoryTest.LessonChapter
{
    [TestClass]
    public class LessonChapterTest
    {
        [TestMethod]
        public void GetNextNumber()
        {
            var lessonId = new Guid("7CCE715F-F7A1-E811-8221-2C600C6934BE");

            var context = new EFDbContext();
            var rep = new EFLessonChapterRepository(context);

            short next = rep.GetNextChapterNumber(lessonId);

            Assert.AreEqual(2, next);
        }

        [TestMethod]
        public void Insert()
        {
            var context = new EFDbContext();
            var rep = new EFLessonChapterRepository(context);

            var chapter = new Domain.Entity.LessonChapter.LessonChapter()
            {
                LSNID = new Guid("7CCE715F-F7A1-E811-8221-2C600C6934BE"),
                LSCTITLE = "Posez les fondations de votre programme",
                LSCDESCRIPTION = "Avant de continuer notre programme, j’ai bien envie de ne plus utiliser l’interpréteur.",
                LSCCONTENT = @"Attends, tu nous as fait tout un pensum sur l’utilisation de l’interpréteur et maintenant tu veux l’abandonner ?
Cher lecteur,
                vous avez raison !Je ne vais pas l’abandonner : je vais plutôt l’utiliser en complément d’un éditeur de texte.

Vous avez certainement remarqué qu’il devient de plus en plus compliqué de travailler avec l’interpréteur.Quand vous le quittez, tout s’efface.Vous devez vous souvenir du code créé.De plus, vous ne pouvez pas modifier facilement une variable.

Peut - être avez - vous déjà commencé à créer un fichier externe pour prendre des notes et conserver une trace des différentes commandes ? C’est exactement ce que nous allons faire: créer un fichier qui conservera nos commandes, une par une, puis lancer le fichier avec python. Au lieu d’entrer, à la main, chaque commande, vous lancerez le programme.C’est plus rapide, non ? !",
                LSCDURATION = 10000000000
            };

            rep.Add(chapter);

            Assert.AreEqual(2, chapter.LSCNUMBER);
        }

        [TestMethod]
        public void FindByNumber()
        {
            var lessonId = new Guid("7cce715f-f7a1-e811-8221-2c600c6934be");
            short number = 2;

            var context = new EFDbContext();
            var rep = new EFLessonChapterRepository(context);

            var chapter = rep.GetByNumber(lessonId, number);

            Console.WriteLine(chapter.LSCTITLE);
        }

        [TestMethod]
        public void GetChapterTitle()
        {
            var lessonId = new Guid("7cce715f-f7a1-e811-8221-2c600c6934be");
            short number = 4;

            var context = new EFDbContext();
            var rep = new EFLessonChapterRepository(context);

            string title = rep.GetChapterTitle(lessonId, number);

            Console.WriteLine(title);
        }

        [TestMethod]
        public void Update()
        {
            var context = new EFDbContext();
            var rep = new EFLessonChapterRepository(context);

            var chapter = new Domain.Entity.LessonChapter.LessonChapter
            {
                LSNID = new Guid("07615C20-00BC-E811-8225-2C600C6934BE"),
                LSCNUMBER = 5,
                LSCTITLE = "Titre de chapitre modifié",
                LSCDESCRIPTION = "Description du chapitre",
                LSCCONTENT = "<p>Contenu important</p>",  
            };

            rep.Update(chapter);
        }
    }
}
