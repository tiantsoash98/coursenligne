using ASTEK.Architecture.BusinessService.Abstract;
using ASTEK.Architecture.BusinessService.Interface;
using ASTEK.Architecture.BusinessService.Validator;
using ASTEK.Architecture.Domain.Validator;
using ASTEK.Architecture.Infrastructure.Domain;
using ASTEK.Architecture.Infrastructure.Exception;
using ASTEK.Architecture.Repository;
using ASTEK.Architecture.Repository.Concrete;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;

namespace ASTEK.Architecture.BusinessService.Entity.LessonChapter
{
    public class LessonChapterBusinessService : EntityServiceBase<Domain.Entity.LessonChapter.LessonChapter>, ILessonChapterBusinessService
    {
        private readonly EFLessonChapterRepository _repository;

        public LessonChapterBusinessService()
        {
            var context = new EFDbContext();
            _repository = new EFLessonChapterRepository(context);
        }

        public CountChapterGroupByLessonResponse Count(CountChapterGroupByLessonRequest request)
        {
            return new CountChapterGroupByLessonResponse()
            {
                Count = _repository.Count(request.LessonId)
            };
        }

        public CreateLessonChapterResponse Create(CreateLessonChapterRequest request)
        {
            try
            {
                var chapter = AssignAvailablePropertiesToDomain(request);

                List<ValidationFailure> errors = new List<ValidationFailure>();

                errors.AddRange(GetErrors(chapter, ValidationType.Add));

                var validator = new CreateLessonChapterValidator(_repository, chapter);
                ValidationResult result = validator.Validate();

                errors.AddRange(result.Errors);

                if (errors.Any())
                {
                    return new CreateLessonChapterResponse
                    {
                        Success = false,
                        ValidationErrors = errors
                    };
                }

                _repository.Add(chapter);

                return new CreateLessonChapterResponse
                {
                    Success = true,
                    Chapter = chapter
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

                return new CreateLessonChapterResponse
                {
                    Success = false,
                    ValidationErrors = validationFailures
                };
            }
            catch (Exception e)
            {
                return new CreateLessonChapterResponse
                {
                    Success = false,
                    Exception = e
                };
            }
        }

        private Domain.Entity.LessonChapter.LessonChapter AssignAvailablePropertiesToDomain(CreateLessonChapterRequest request)
        {
            var chapter = new Domain.Entity.LessonChapter.LessonChapter
            {
                LSNID = request.LessonId,
                LSCCONTENT = request.Content,
                LSCDESCRIPTION = request.Description,
                LSCTITLE = request.Title,
                LSCDURATION = request.Duration    
            };

            return chapter;
        }

        public GetChapterByNumberResponse GetByNumber(GetChapterByNumberRequest request)
        {
            var chapter = _repository.GetByNumber(request.LessonId, request.Number, request.LoadChildren);

            if(chapter == null)
            {
                return new GetChapterByNumberResponse
                {
                    Success = false,
                    Exception = new EntityNotFoundException(Infrastructure.InfrastructureStrings.NotFound_Chapter)
                };
            }

            return new GetChapterByNumberResponse
            {
                Success = true,
                Chapter = chapter
            };
        }

        public override List<ValidationFailure> GetErrors(Domain.Entity.LessonChapter.LessonChapter entity, ValidationType validationType)
        {
            return new LessonChapterValidator(validationType).Validate(entity).Errors.ToList();
        }

        public GetChapterTitleResponse GetTitle(GetChapterTitleRequest request)
        {
            string title = _repository.GetChapterTitle(request.LessonId, request.ChapterNumber);

            if (string.IsNullOrEmpty(title))
            {
                return new GetChapterTitleResponse
                {
                    Success = false,
                    Exception = new EntityNotFoundException(Infrastructure.InfrastructureStrings.NotFound_Chapter)
                };
            }

            return new GetChapterTitleResponse
            {
                Success = true,
                Title = title
            };
        }

        public UpdateChapterResponse Update(UpdateChapterRequest request)
        {
            try
            {
                List<ValidationFailure> errors = new List<ValidationFailure>();

                var chapter = new Domain.Entity.LessonChapter.LessonChapter
                {
                    LSCCONTENT = request.Content,
                    LSCDESCRIPTION = request.Description,
                    LSCNUMBER = request.ChapterNumber,
                    LSCDURATION = request.Duration,
                    LSCTITLE = request.Title,
                    LSNID = request.LessonId
                };

                errors.AddRange(GetErrors(chapter, ValidationType.Update));

                if (errors.Any())
                {
                    return new UpdateChapterResponse
                    {
                        Success = false,
                        ValidationFailures = errors
                    };
                }

                var updated = _repository.Update(chapter);

                return new UpdateChapterResponse
                {
                    Success = true,
                    Updated = updated
                };
            }
            catch (Exception ex)
            {
                return new UpdateChapterResponse
                {
                    Success = false,
                    Exception = ex
                };
            }
        }
    }
}
