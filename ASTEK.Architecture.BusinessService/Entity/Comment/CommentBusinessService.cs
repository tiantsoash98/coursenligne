using ASTEK.Architecture.BusinessService.Abstract;
using ASTEK.Architecture.BusinessService.Interface;
using ASTEK.Architecture.Domain.Validator;
using ASTEK.Architecture.Infrastructure.Domain;
using ASTEK.Architecture.Repository;
using ASTEK.Architecture.Repository.Concrete;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;

namespace ASTEK.Architecture.BusinessService.Entity.Comment
{
    public class CommentBusinessService: EntityServiceBase<Domain.Entity.Comment.Comment>, ICommentBusinessService
    {
        private readonly EFCommentRepository _repository;

        public CommentBusinessService()
        {
            var context = new EFDbContext();
            _repository = new EFCommentRepository(context);
        }

        public AddCommentResponse Add(AddCommentRequest request)
        {
            try
            {
                var comment = new Domain.Entity.Comment.Comment
                {
                    ACCID = request.AccountId,
                    COMDATE = DateTime.Now,
                    LSNID = request.LessonId,
                    COMCONTENT = request.Content
                };

                List<ValidationFailure> errors = GetErrors(comment, ValidationType.Add);

                if (errors.Any())
                {
                    return new AddCommentResponse
                    {
                        Success = false,
                        ValidationFailures = errors
                    };
                }

                _repository.Add(comment);

                return new AddCommentResponse
                {
                    Success = true,
                    Comment = comment
                };
            }
            catch (DbEntityValidationException e)
            {
                List<ValidationFailure> validationFailures = new List<ValidationFailure>();

                foreach (var eve in e.EntityValidationErrors)
                {
                    foreach (var ve in eve.ValidationErrors)
                    {
                        validationFailures.Add(new ValidationFailure(ve.PropertyName, ve.ErrorMessage));
                    }
                }

                return new AddCommentResponse
                {
                    Success = false,
                    ValidationFailures = validationFailures
                };
            }
            catch (Exception e)
            {
                return new AddCommentResponse
                {
                    Success = false,
                    Exception = e
                };
            }
        }

        public override List<ValidationFailure> GetErrors(Domain.Entity.Comment.Comment entity, ValidationType validationType)
        {
            return new CommentValidator(validationType).Validate(entity).Errors.ToList();
        }
    }
}
