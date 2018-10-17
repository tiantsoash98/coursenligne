using System;
using System.Collections.Generic;
using ASTEK.Architecture.Domain.Validator;
using ASTEK.Architecture.Infrastructure.Domain;
using FluentValidation.Results;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ASTEK.Architecture.DomainTest.Lesson
{
    [TestClass]
    public class LessonTests
    {
        [TestMethod]
        public void GetValidator()
        {
            var lesson = new Domain.Entity.Lesson.Lesson()
            {
                ACCID = new Guid("9AB7771D-F69F-E811-8220-2C600C6934BE"),
                LSNTITLE = "NinKFDQoov0QmbJEJ-7UAkbAagpMNvvhpcMbfGOuYxaTTIrOve7YkWZdkpbBjnZ15dJkj0W_Pa_3C5WiODZc_gX75myOh8bfSsc4n68-rFZA4fQ8GRirFPSMKUdU4QSwlDAd-ymjX1WdYgaDg1ctSg25dJkj0W_Pa_3C5WiODZc_gX75myOh8bfSsc4n68-rFZA4fQ8GRirFPSMKUdU4QSwlDAd-ymjX1WdYgaDg1ctSg2",
                STDCODE = new Guid("E97DC2F7-9B9C-E811-8220-2C600C6934BE"), // MARKETING
                //LSNDESCRIPTION= @"Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt

                //                ut labore et dolore magna aliqua.Lorem ipsum dolor sit amet,
                //consectetur

                //                Ut enim ad minim veniam",
                LSNDESCRIPTION = "he",
                LSNTARGET = "Comprendre ce qu'est le marketing visuel|Apprehender sa place dans la société actuelle",
                DCFCODE = new Guid("7CCAF4E2-CF9E-E811-8220-2C600C6934BE")
            };

            var validator = new LessonValidator(ValidationType.Add);
            ValidationResult result = validator.Validate(lesson);
            IEnumerable<ValidationFailure> errors = result.Errors;

            foreach (var error in errors)
            {
                Console.WriteLine(error.PropertyName + ": " +error.ErrorMessage);
            }

            Assert.IsFalse(result.IsValid);
        }
    }
}
