using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ASTEK.Architecture.ApplicationService.Entity.LessonChapter;

namespace ASTEK.Architecture.ApplicationServiceTest.LessonChapter
{
    [TestClass]
    public class ChapterAppTest
    {
        [TestMethod]
        public void FindByNumber()
        {
            string lessonId = "7cce715f-f7a1-e811-8221-2c600c6934be";
            short number = 1;

            var chapterAppService = new LessonChapterAppService();

            GetChapterByNumberOutputModel chapterOutput = chapterAppService.GetByNumber(new GetChapterByNumberInputModel() { LessonId = lessonId, Number = number });

            Console.WriteLine(chapterOutput.Response.Chapter.LSCTITLE);

            Assert.IsTrue(chapterOutput.Response.Success);
        }

        [TestMethod]
        public void Create()
        {
            var input = new CreateLessonChapterInputModel()
            {
                LessonId = "0FF0CC52-58BA-E811-8225-2C600C6934BE",
                Title = "Test chapitre 2",
                Description = "Une difficulté supplémentaire, c'est que l'introspection, pour être une connaissance, doit viser la vérité. Par conséquent, elle doit être sincère. Or, celui qui s'observe peut avoir intérêt à cacher une partie de ce qu'il découvre, de façon plus ou moins consciente. En réalité, même si l'introspection se présente comme une conduite de sincérité, son but réel n'est pas la connaissance de soi. C'est ce que révèle l'analyse des récits autobiographiques. Toute une littérature est dominée par le souci de l'introspection et de la sincérité.",
                Content = "<p style=\"margin - left:0cm; margin - right:0cm; text - align:justify\">Cette tradition naît avec Montaigne. Au début des Essais, l'avis au lecteur prévient, dès les premiers mots: «Ceci est un livre de bonne foi» . Plus loin, l'auteur exprime sa volonté de «se peindre (...) tout nu», sans masque. Elle est continuée par Rousseau qui déclare, dans les Confessions: «Je veux montrer à mes semblables un homme dans toute la vérité de la nature». Dans l'exercice littéraire de la connaissance de soi par soi s'annonce un souci de sincérité. Mais ce qui est visé n'est pas la connaissance de soi. Ce qui explique l'échec constaté par Rousseau, plus tard, dans les Rêveries: «Parfois j'ai caché le côté difforme en me peignant de profil» (4ème promenade). </ br>En réalité, l'enjeu est tout autre. Ce genre littéraire, qui prétend avoir pour but la connaissance de soi, ne prend en réalité son sens que si on le met en relation avec un certain type de conduite religieuse. Cet exercice ne fait que répéter un comportement religieux: celui de la confession. A cet égard, le titre du livre de Rousseau en dit plus qu'il ne voudrait.Le but de la confession ou de l'aveu n'est pas la connaissance de soi, mais la libération à l'égard du mal que l'on a commis, la délivrance du remords, une sorte d'exorcisme. Il est clair que c'est là le véritable enjeu des Confessions de Rousseau: se persuader qu'il n'est pas méchant. </p>",
            };

            var service = new LessonChapterAppService();

            CreateLessonChapterOutputModel output = service.Create(input);

            Assert.IsTrue(output.Response.Success);
        }

        [TestMethod]
        public void Update()
        {
            var input = new UpdateLessonChapterInputModel
            {
                LessonId = "07615C20-00BC-E811-8225-2C600C6934BE",
                ChapterNumber = 5,
                Title = "Test update chapitre 5bc",
                Description = "Une difficulté supplémentaire, c'est que l'introspection, pour être une connaissance, doit viser la vérité. Par conséquent, elle doit être sincère. Or, celui qui s'observe peut avoir intérêt à cacher une partie de ce qu'il découvre, de façon plus ou moins consciente. En réalité, même si l'introspection se présente comme une conduite de sincérité, son but réel n'est pas la connaissance de soi. C'est ce que révèle l'analyse des récits autobiographiques. Toute une littérature est dominée par le souci de l'introspection et de la sincérité.",
                Content = "<p style=\"margin - left:0cm; margin - right:0cm; text - align:justify\">Cette tradition naît avec Montaigne. Au début des Essais, l'avis au lecteur prévient, dès les premiers mots: «Ceci est un livre de bonne foi» . Plus loin, l'auteur exprime sa volonté de «se peindre (...) tout nu», sans masque. Elle est continuée par Rousseau qui déclare, dans les Confessions: «Je veux montrer à mes semblables un homme dans toute la vérité de la nature». Dans l'exercice littéraire de la connaissance de soi par soi s'annonce un souci de sincérité. Mais ce qui est visé n'est pas la connaissance de soi. Ce qui explique l'échec constaté par Rousseau, plus tard, dans les Rêveries: «Parfois j'ai caché le côté difforme en me peignant de profil» (4ème promenade). </ br>En réalité, l'enjeu est tout autre. Ce genre littéraire, qui prétend avoir pour but la connaissance de soi, ne prend en réalité son sens que si on le met en relation avec un certain type de conduite religieuse. Cet exercice ne fait que répéter un comportement religieux: celui de la confession. A cet égard, le titre du livre de Rousseau en dit plus qu'il ne voudrait.Le but de la confession ou de l'aveu n'est pas la connaissance de soi, mais la libération à l'égard du mal que l'on a commis, la délivrance du remords, une sorte d'exorcisme. Il est clair que c'est là le véritable enjeu des Confessions de Rousseau: se persuader qu'il n'est pas méchant. </p>",
                Hours = 2,
                Minutes = 5
            };

            var service = new LessonChapterAppService();

            UpdateLessonChapterOutputModel output = service.Update(input);

            Assert.IsTrue(output.Response.Success);
        }
    }
}
