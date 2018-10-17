using System;
using ASTEK.Architecture.BusinessService.Entity.LessonPart;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ASTEK.Architecture.BusinessServicesTest.LessonPart
{
    [TestClass]
    public class LessonPartBusinessTests
    {
        [TestMethod]
        public void Create()
        {
            var request = new CreateLessonPartRequest()
            {
                ChapterCode = new Guid("8740251B-1CB0-E811-8222-2C600C6934BE"),
                Title = "Le vrai moi est intérieur",
                Content = "<h4>Que suis-je?</h4> Qu'est-ce qui fait mon identité? On pourra être tenté de répondre que c'est mon apparence physique, en particulier mon visage. Cela est personnel. Seulement, mes traits changent avec le temps, au point qu'un ami perdu de vue aura du mal à me reconnaître après une longue absence. \"Celui qui aime quelqu'un à cause de sa beauté, l'aime - t - il ? Non; car la petite vérole, qui tuera la beauté sans tuer la personne, fera qu'il ne l'aimera plus\" (Pascal, Pensées, 323 Br.). La \"personne\" ne se réduit donc pas à l'apparence physique. Si l'on m'aime pour ma beauté, on ne m'aime pas, moi. Qu'est-ce donc que ce moi? Mon code génétique? Les scientifiques nous disent qu'il est unique.Pourtant, deux frères jumeaux possèdent une identité qui interdit de les confondre.Il consisterait plutôt en quelque chose d'intérieur - ce qu'on appelle la personnalité. Certes, mon caractère peut changer lui aussi. Mais on pourrait supposer l'existence d'un noyau stable, que l'on pourra appeler le moi. Si j'ai conscience d'une identité, il faut donc en chercher l'origine dans la conscience plutôt que dans le corps.Plutôt dans ce \"je\", sujet de pensée et d'action, qui commande au corps. Moi seul puis donc savoir qui je suis. En effet, ce que je donne à voir à mon entourage, cela est - il vraiment moi ? Est - ce que ce ne sont pas seulement des apparences trompeuses? Il se peut que je porte un masque.Balzac a parlé de la \"comédie humaine\".Un empereur romain avait eu pour dernier mot: \"comedia finita est\".On trouvera chez Sartre cette idée que chacun, en société, joue un rôle qu'il prend plus ou moins au sérieux, auquel il s'identifie plus ou moins bien.Par conséquent, ma véritable personnalité, pourra-t - on penser, s'identifie avec la partie la plus intime, la plus cachée de moi-même, celle que moi seul puis connaître: l'intériorité de ma conscience. Le vrai moi est caché. Le domaine de la conscience est celui de l'intériorité, une intériorité inaccessible et impénétrable pour l'autre.Ma subjectivité est comme une forteresse où je peux me réfugier et trouver la paix si l'on m'agresse.Personne ne peut venir y troubler la paix que je décide d'y faire régner. Pressé de questions, si je décide de garder le silence, personne ne pourra violer cette intimité. L'intériorité de la conscience est un refuge.On peut bien m'obliger à faire ce que je réprouve, on ne peut pas contraindre mes pensées. L'esclave peut ainsi rêver qu'il est libre. La contrepartie, c'est que \"mon jardin secret est une prison\"(Gaston Berger, Du prochain au semblable: esquisse d'une phénoménologie de la solitude)."
            };

            var businessService = new LessonPartBusinessService();
            var response = businessService.Create(request);

            Assert.IsTrue(response.Success);
        }

        [TestMethod]
        public void CreateWithInvalidValues()
        {
            var request = new CreateLessonPartRequest()
            {
                ChapterCode = new Guid("8740251B-1CB0-E811-8222-2C600C6934BE"),
                Title = "a",
                Content = "<h4>Que suis-je?</h4> Qu'est-ce qui fait mon identité? On pourra être tenté de répondre que c'est mon apparence physique, en particulier mon visage. Cela est personnel. Seulement, mes traits changent avec le temps, au point qu'un ami perdu de vue aura du mal à me reconnaître après une longue absence. \"Celui qui aime quelqu'un à cause de sa beauté, l'aime - t - il ? Non; car la petite vérole, qui tuera la beauté sans tuer la personne, fera qu'il ne l'aimera plus\" (Pascal, Pensées, 323 Br.). La \"personne\" ne se réduit donc pas à l'apparence physique. Si l'on m'aime pour ma beauté, on ne m'aime pas, moi. Qu'est-ce donc que ce moi? Mon code génétique? Les scientifiques nous disent qu'il est unique.Pourtant, deux frères jumeaux possèdent une identité qui interdit de les confondre.Il consisterait plutôt en quelque chose d'intérieur - ce qu'on appelle la personnalité. Certes, mon caractère peut changer lui aussi. Mais on pourrait supposer l'existence d'un noyau stable, que l'on pourra appeler le moi. Si j'ai conscience d'une identité, il faut donc en chercher l'origine dans la conscience plutôt que dans le corps.Plutôt dans ce \"je\", sujet de pensée et d'action, qui commande au corps. Moi seul puis donc savoir qui je suis. En effet, ce que je donne à voir à mon entourage, cela est - il vraiment moi ? Est - ce que ce ne sont pas seulement des apparences trompeuses? Il se peut que je porte un masque.Balzac a parlé de la \"comédie humaine\".Un empereur romain avait eu pour dernier mot: \"comedia finita est\".On trouvera chez Sartre cette idée que chacun, en société, joue un rôle qu'il prend plus ou moins au sérieux, auquel il s'identifie plus ou moins bien.Par conséquent, ma véritable personnalité, pourra-t - on penser, s'identifie avec la partie la plus intime, la plus cachée de moi-même, celle que moi seul puis connaître: l'intériorité de ma conscience. Le vrai moi est caché. Le domaine de la conscience est celui de l'intériorité, une intériorité inaccessible et impénétrable pour l'autre.Ma subjectivité est comme une forteresse où je peux me réfugier et trouver la paix si l'on m'agresse.Personne ne peut venir y troubler la paix que je décide d'y faire régner. Pressé de questions, si je décide de garder le silence, personne ne pourra violer cette intimité. L'intériorité de la conscience est un refuge.On peut bien m'obliger à faire ce que je réprouve, on ne peut pas contraindre mes pensées. L'esclave peut ainsi rêver qu'il est libre. La contrepartie, c'est que \"mon jardin secret est une prison\"(Gaston Berger, Du prochain au semblable: esquisse d'une phénoménologie de la solitude)."
            };

            var businessService = new LessonPartBusinessService();
            var response = businessService.Create(request);

            Console.WriteLine(response.Exception);

            response.ValidationErrors.ForEach(x =>
            {
                Console.WriteLine(x.PropertyName + ": " + x.ErrorMessage);
            });

            Assert.IsFalse(response.Success);
        }

        [TestMethod]
        public void CreateAll()
        {
            var request = new CreateAllLessonPartRequest()
            {
                ChapterCode = new Guid("43E62DF7-39B0-E811-8222-2C600C6934BE"),
                Parts = new System.Collections.Generic.List<CreateLessonPartRequest>()
                {
                    new CreateLessonPartRequest()
                    {
                        Title = "How Did Van Gogh's Turbulent Mind Depict One of the Most Complex Concepts in Physics?",
                        Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor"
                    },
                    new CreateLessonPartRequest()
                    {
                        Title = "incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam,",
                        Content = "architecto beatae vitae dicta sunt explicabo."
                    },
                    new CreateLessonPartRequest()
                    {
                        Title = "ed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque",
                        Content = "Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit,"
                    },
                }
            };

            var businessService = new LessonPartBusinessService();
            var response = businessService.CreateAll(request);

            Assert.IsTrue(response.Success);
        }
    }
}
