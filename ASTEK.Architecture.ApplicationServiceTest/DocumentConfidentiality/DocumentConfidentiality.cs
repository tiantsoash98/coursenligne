using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ASTEK.Architecture.ApplicationService.Entity.DocumentConfidentiality;

namespace ASTEK.Architecture.ApplicationServiceTest.DocumentConfidentiality
{
    [TestClass]
    public class DocumentConfidentiality
    {
        [TestMethod]
        public void GetAll()
        {
            var appService = new DocumentConfidentialityAppService();
            GetAllDocumentConfidentialityOutputModel output = appService.GetAll(new GetAllDocumentConfidentialityInputModel());

            Assert.AreEqual(1, output.Response.DocumentsConfidentialities.Count);
        }
    }
}
