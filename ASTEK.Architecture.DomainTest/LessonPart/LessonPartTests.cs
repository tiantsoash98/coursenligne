using System;
using System.Collections.Generic;
using ASTEK.Architecture.Domain.Validator;
using ASTEK.Architecture.Infrastructure.Domain;
using FluentValidation.Results;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ASTEK.Architecture.DomainTest.LessonPart
{
    [TestClass]
    public class LessonPartTests
    {
        [TestMethod]
        public void GetValidator()
        {
            var lessonPart = new Domain.Entity.LessonPart.LessonPart
            {
                LSPTITLE = "aa",
                LSPCONTENT = "a",
            };

            var validator = new LessonPartValidator(ValidationType.Add);
            ValidationResult result = validator.Validate(lessonPart);
            IEnumerable<ValidationFailure> errors = result.Errors;

            foreach (var error in errors)
            {
                Console.WriteLine(error.PropertyName + ": " + error.ErrorMessage);
            }

            Assert.IsFalse(result.IsValid);
        }
    }
}
