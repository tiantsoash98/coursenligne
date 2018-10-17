using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ASTEK.Architecture.Infrastructure.Validator.Concrete;
using FluentValidation.Results;

namespace ASTEK.Architecture.InfrastructureTest
{
    [TestClass]
    public class ValidatorTest
    {
        [TestMethod]
        public void NameValidator()
        {
            var name = "Jean-Paulé";

            NameValidator validator = new NameValidator(Infrastructure.InfrastructureStrings.Display_Name);  
            ValidationResult result = validator.Validate(name);

            foreach(var error in result.Errors)
            {
                Console.WriteLine(error.ErrorMessage);
            }

            Assert.IsTrue(result.IsValid);
        }

        [TestMethod]
        public void AddressValidator()
        {
            var address = "1a+1 23a aa";

            var validator = new AddressValidator();
            ValidationResult result = validator.Validate(address);

            foreach (var error in result.Errors)
            {
                Console.WriteLine(error.ErrorMessage);
            }

            Assert.IsFalse(result.IsValid);
        }

        [TestMethod]
        public void PostalCodeValidator()
        {
            var postalCode = "123 12a";

            var validator = new PostalCodeValidator();
            ValidationResult result = validator.Validate(postalCode);

            foreach (var error in result.Errors)
            {
                Console.WriteLine(error.ErrorMessage);
            }

            Assert.IsFalse(result.IsValid);
        }

        [TestMethod]
        public void TitleValidator()
        {
            var title = "....";

            var validator = new TitleValidator();
            ValidationResult result = validator.Validate(title);

            foreach (var error in result.Errors)
            {
                Console.WriteLine(error.ErrorMessage);
            }

            Assert.IsFalse(result.IsValid);
        }
    }
}
