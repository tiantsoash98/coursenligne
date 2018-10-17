using System;
using ASTEK.Architecture.Repository;
using ASTEK.Architecture.Repository.Concrete;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ASTEK.Architecture.RepositoryTest.Study
{
    [TestClass]
    public class StudyTest
    {
        [TestMethod]
        public void GetPicture()
        {
            var id = new Guid("8CDE8A70-9B9C-E811-8220-2C600C6934BE");

            var ctx = new EFDbContext();
            var rep = new EFStudyRepository(ctx);

            Assert.AreEqual("science.jpg", rep.GetPicture(id));
        }

        [TestMethod]
        public void FindAllWithCulture()
        {
            var context = new EFDbContext();
            var rep = new EFStudyRepository(context);

            var list = rep.FindAll("en-US");

            foreach (var item in list)
            {
                Console.WriteLine(item.STDCODE + " " + item.STDNAME);
            }
        }
    }
}
