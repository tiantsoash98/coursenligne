using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using ASTEK.Architecture.BusinessService.Abstract;
using ASTEK.Architecture.BusinessService.Interface;
using ASTEK.Architecture.Domain.Entity.CommentAnswer;
using ASTEK.Architecture.Domain.Validator;
using ASTEK.Architecture.Infrastructure.Domain;
using ASTEK.Architecture.Repository;
using ASTEK.Architecture.Repository.Concrete;
using FluentValidation.Results;

namespace ASTEK.Architecture.BusinessService.Entity.CommentAnswer
{
    public class CommentAnswerBusinessService : EntityServiceBase<Domain.Entity.CommentAnswer.CommentAnswer>, ICommentAnswerBusinessService
    {
        private readonly EFCommentAnswerRepository _repository;

        public CommentAnswerBusinessService()
        {
            var context = new EFDbContext();
            _repository = new EFCommentAnswerRepository(context);
        }

        public AddCommentAnswerResponse Add(AddCommentAnswerRequest request)
        {
            try
            {
                var answer = new Domain.Entity.CommentAnswer.CommentAnswer
                {
                    ACCID = request.AccountId,
                    COMID = request.CommentId,
                    CANDATE = DateTime.Now,
                    CANCONTENT = request.Content
                };

                List<ValidationFailure> errors = GetErrors(answer, ValidationType.Add);

                if (errors.Any())
                {
                    return new AddCommentAnswerResponse
                    {
                        Success = false,
                        ValidationFailures = errors
                    };
                }

                _repository.Add(answer);

                return new AddCommentAnswerResponse
                {
                    Success = true,
                    CommentAnswer = answer
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

                return new AddCommentAnswerResponse
                {
                    Success = false,
                    ValidationFailures = validationFailures
                };
            }
            catch (Exception e)
            {
                return new AddCommentAnswerResponse
                {
                    Success = false,
                    Exception = e
                };
            }
        }

        public GetAllCommentAnswerResponse GetAll(GetAllCommentAnswerRequest request)
        {
            try
            {
                var answers = _repository.FindAll(request.CommentId);

                List<Domain.Entity.CommentAnswer.CommentAnswer> pagedList = answers;

                if (request.Count > 0)
                {
                    pagedList = answers.OrderByDescending(c => c.CANDATE)
                                                                        .Take(request.Count)
                                                                        .ToList();
                }

                return new GetAllCommentAnswerResponse
                {
                    Success = true,
                    CommentAnswers = pagedList
                };
            }
            catch (Exception ex)
            {
                return new GetAllCommentAnswerResponse
                {
                    Success = false,
                    Exception = ex
                };
            }
        }

        public override List<ValidationFailure> GetErrors(Domain.Entity.CommentAnswer.CommentAnswer entity, ValidationType validationType)
        {
            return new CommentAnswerValidator(validationType).Validate(entity).Errors.ToList();
        }
    }
}
