using System;
using System.Collections.Generic;
using ASTEK.Architecture.Domain.Validator;
using ASTEK.Architecture.Infrastructure.Domain;
using FluentValidation.Results;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ASTEK.Architecture.DomainTest.LessonChapter
{
    [TestClass]
    public class LessonChapterTests
    {
        [TestMethod]
        public void GetValidator()
        {
            var lessonChapter = new Domain.Entity.LessonChapter.LessonChapter
            {
                LSCDESCRIPTION = "aa",
                LSCCONTENT = "NinKFDQoov0QmbJEJ-7UAkbAagpMNvvhpcMbfGOuYxaTTIrOve7YkWZdkpbBjnZ15dJkj0W_Pa_3C5WiODZc_gX75myOh8bfSsc4n68-rFZA4fQ8GRirFPSMKUdU4QSwlDAd-ymjX1WdYgaDg1ctSg25dJkj0W_Pa_3C5WiODZc_gX75myOh8bfSsc4n68-rFZA4fQ8GRirFPSMKUdU4QSwlDAd-ymjX1WdYgaDg1ctSg2",
            };

            var validator = new LessonChapterValidator(ValidationType.Add);
            ValidationResult result = validator.Validate(lessonChapter);
            IEnumerable<ValidationFailure> errors = result.Errors;

            foreach (var error in errors)
            {
                Console.WriteLine(error.PropertyName + ": " + error.ErrorMessage);
            }

            Assert.IsFalse(result.IsValid);
        }
    }
}
