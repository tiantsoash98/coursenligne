using ASTEK.Architecture.Repository;
using ASTEK.Architecture.Repository.Concrete;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace ASTEK.Architecture.RepositoryTest.LessonPart
{
    [TestClass]
    public class LessonPartTest
    {
        [TestMethod]
        public void GetNextNumber()
        {
            var chapterCode = new Guid("AF0DC92E-78A7-E811-8221-2C600C6934BE");

            var context = new EFDbContext();
            var rep = new EFLessonPartRepository(context);

            short next = rep.GetNextPartNumber(chapterCode);

            Assert.AreEqual(1, next);
        }

        [TestMethod]
        public void Insert()
        {
            var context = new EFDbContext();
            var rep = new EFLessonPartRepository(context);

            var part = new Domain.Entity.LessonPart.LessonPart()
            {
                LSCCODE = new Guid("4F49B93A-81BA-E811-8225-2C600C6934BE"),
                LSPTITLE = "Test Part 3",
                LSPCONTENT = @"Intéressons-nous maintenant à l’interaction avec l’utilisateur. La première phrase qui s’affichera sera une citation au hasard. Puis, nous proposerons deux alternatives :

Si l’utilisateur tape “entrée”, une nouvelle citation apparaît.

S’il tape “B”, le programme se ferme.

Nous allons commencer par écrire du pseudo-code, c’est-à-dire écrire ce que nous voulons que le programme fasse avec nos propres mots. Il s’agit d’une pratique très courante chez les développeurs.

 Tout mon code est écrit en anglais. Non pas que je souhaite mettre en avant mes incroyables talents linguistiques, mais plutôt car la langue du développement est l’anglais. Qui sait ce que deviendra votre projet demain ? Vous pouvez choisir de le rendre disponible en open source pour que chacun puisse y contribuer, y compris des non-francophones. Ou bien vous pouvez le vendre. En plus les accents français ne sont pas acceptés dans les noms de variables. Bref, coder en anglais est une bonne pratique. Rassurez-vous : il s’agit de mots simples et vous comprendrez tout.

La logique voudrait qu’on utilise le signe  =  pour comparer deux valeurs. Mais, si vous vous souvenez bien, ce signe est déjà utilisé pour assigner une valeur à une variable. Nous ne pouvons donc pas l’utiliser pour comparer !

C’est pourquoi nous doublons le signe égal par un autre égal pour signifier la comparaison, comme ceci :  ==  .

Les opérateurs de comparaison renvoient un booléen ( True  ou  False ) car vous posez une question fermée : c’est vrai ou ça ne l’est pas !

Integer egestas, neque eget pellentesque lacinia, sem magna fermentum purus, et blandit neque lorem id ipsum. In hac habitasse platea dictumst. Etiam semper est lacus, a consectetur tortor malesuada id. Nunc egestas massa sapien, nec tempus eros ullamcorper nec. Nam eros risus, efficitur et hendrerit non, ultricies sit amet sem. Fusce varius diam eu iaculis varius. Praesent sodales, tortor a gravida pharetra, nulla ligula accumsan sem, quis suscipit erat eros ut massa. Aenean dictum nibh posuere neque rutrum, quis congue turpis pharetra. Curabitur sed cursus justo, nec facilisis tortor. Integer nec justo vehicula, pharetra eros in, consectetur mi. Fusce hendrerit rhoncus arcu nec convallis. Proin quis neque vitae dolor lacinia mollis a id ipsum. Nulla ornare lorem vitae lacus accumsan semper. Donec iaculis est mauris, ut varius magna maximus vel.

Vestibulum ornare at orci in volutpat. Etiam ac risus vitae lectus laoreet scelerisque. Vivamus ut vestibulum ipsum. Quisque malesuada ante pretium nunc ultricies, et congue enim faucibus. Sed lobortis diam eget ipsum mattis feugiat. Vestibulum rutrum imperdiet pellentesque. Suspendisse tristique varius risus. Proin vel pharetra nisi. Ut ante tellus, eleifend eget tortor sed, posuere sollicitudin dui. Morbi elementum tellus non condimentum aliquam. Mauris eget vulputate nisl. Curabitur pharetra tortor neque, eget sodales leo pretium eu.

Nam ullamcorper metus non urna lacinia porttitor. Nulla facilisis ligula sit amet tellus consectetur, a feugiat quam egestas. Nam ac faucibus lorem. Duis tristique nibh vel ligula tristique efficitur. Morbi dapibus egestas ex, quis finibus neque semper vitae. Aenean est mi, dictum quis urna ut, euismod scelerisque diam. Nunc molestie ipsum at facilisis molestie. Maecenas imperdiet nunc nunc, vitae faucibus justo eleifend sagittis. Pellentesque accumsan dictum urna sollicitudin ornare. Vestibulum efficitur nibh ac ex pulvinar, quis sollicitudin augue facilisis. Praesent posuere, lorem ut maximus aliquet, urna nibh aliquet libero, id faucibus nulla erat et mi. Ut auctor metus quis est sodales hendrerit. Nullam orci erat, aliquet eu fermentum et, maximus quis ipsum.

Maecenas enim ipsum, molestie vitae consectetur in, sagittis ac tellus. Suspendisse interdum urna ac orci elementum, luctus sodales ligula lacinia. Nunc id pharetra sem, ac interdum ipsum. Phasellus tempus feugiat odio sagittis mattis. Cras tempus rutrum sem ac sodales. Nullam sapien odio, finibus id turpis quis, vulputate ullamcorper felis. Fusce felis massa, molestie ac vestibulum nec, eleifend ac sem. Quisque vitae risus velit. Sed euismod urna quis auctor aliquet. Suspendisse accumsan metus leo, eleifend dapibus sem cursus at. Vivamus condimentum interdum ante, vel egestas arcu ornare et. Donec mollis non nulla nec mattis."
            };

            rep.Add(part);

            Assert.AreEqual(1, part.LSPNUMBER);
        }

        [TestMethod]
        public void FindByNumber()
        {
            var lessonId = new Guid("7cce715f-f7a1-e811-8221-2c600c6934be");
            short chapterNumber = 2;
            short number = 2;

            var context = new EFDbContext();
            var rep = new EFLessonPartRepository(context);

            var part = rep.FindByNumber(lessonId, chapterNumber, number);

            Console.WriteLine(part.LSPTITLE);
        }

        [TestMethod]
        public void UpdateRange()
        {
            var chapterCode = new Guid("5BCF88F5-59C1-E811-8226-2C600C6934BE");

            List<Domain.Entity.LessonPart.LessonPart> parts = new List<Domain.Entity.LessonPart.LessonPart>
            {
                new Domain.Entity.LessonPart.LessonPart
                {
                    LSPTITLE = "Titre partie 1 new",
                    LSPCONTENT = "<p>Contenu partie 1</p>"       
                },
                new Domain.Entity.LessonPart.LessonPart
                {
                    LSPTITLE = "Titre partie 2 new ",
                    LSPCONTENT = "<p>Contenu partie 2</p>"
                },
                new Domain.Entity.LessonPart.LessonPart
                {
                    LSPTITLE = "Titre partie 2 b new ",
                    LSPCONTENT = "<p>Contenu partie 2 b</p>"
                },
                new Domain.Entity.LessonPart.LessonPart
                {
                    LSPTITLE = "Titre partie 3b",
                    LSPCONTENT = "<p>Contenu partie 3b</p>"
                }
            };

            var context = new EFDbContext();
            var rep = new EFLessonPartRepository(context);

            rep.UpdateRange(chapterCode, parts);
        }
    }
}
