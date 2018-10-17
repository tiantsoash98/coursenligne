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

namespace ASTEK.Architecture.BusinessService.Entity.LessonPart
{
    public class LessonPartBusinessService : EntityServiceBase<Domain.Entity.LessonPart.LessonPart>, ILessonPartBusinessService
    {
        private readonly EFLessonPartRepository _repository;

        public LessonPartBusinessService()
        {
            var context = new EFDbContext();
            _repository = new EFLessonPartRepository(context);
        }

        public CountPartGroupByChapterResponse Count(CountPartGroupByChapterRequest request)
        {
            return new CountPartGroupByChapterResponse
            {
                Count = _repository.Count(request.ChapterCode)
            };
        }

        public CreateLessonPartResponse Create(CreateLessonPartRequest request)
        {
            try
            {
                Domain.Entity.LessonPart.LessonPart part = AssignAvailablePropertiesToDomain(request);

                List<ValidationFailure> errors = ValidateCreateLessonPartRequest(part);

                if (errors.Any())
                {
                    return new CreateLessonPartResponse
                    {
                        Success = false,
                        ValidationErrors = errors
                    };
                }

                _repository.Add(part);

                return new CreateLessonPartResponse
                {
                    Success = true,
                    Part = part
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

                return new CreateLessonPartResponse
                {
                    Success = false,
                    ValidationErrors = validationFailures
                };
            }
            catch (Exception e)
            {
                return new CreateLessonPartResponse
                {
                    Success = false,
                    Exception = e
                };
            }
        }

        private Domain.Entity.LessonPart.LessonPart AssignAvailablePropertiesToDomain(CreateLessonPartRequest request)
        {
            var part = new Domain.Entity.LessonPart.LessonPart
            {
                LSCCODE = request.ChapterCode,
                LSPCONTENT = request.Content,
                LSPTITLE = request.Title
            };

            return part;
        }

        public GetPartByNumberResponse GetByNumber(GetPartByNumberRequest request)
        {
            var part = _repository.FindByNumber(request.LessonId, request.ChapterNumber, request.Number);

            if (part == null)
            {
                return new GetPartByNumberResponse
                {
                    Success = false,
                    Exception = new EntityNotFoundException(Infrastructure.InfrastructureStrings.NotFound_Part)
                };
            }

            return new GetPartByNumberResponse
            {
                Success = true,
                Part = part
            };
        }

        public override List<ValidationFailure> GetErrors(Domain.Entity.LessonPart.LessonPart entity, ValidationType validationType)
        {
            return new LessonPartValidator(validationType).Validate(entity).Errors.ToList();
        }

        public CreateAllLessonPartResponse CreateAll(CreateAllLessonPartRequest request)
        {
            try
            {
                List<ValidationFailure> errors = new List<ValidationFailure>();
                List<Domain.Entity.LessonPart.LessonPart> parts = new List<Domain.Entity.LessonPart.LessonPart>();

                foreach(var partRequest in request.Parts)
                {
                    var part = AssignAvailablePropertiesToDomain(partRequest);

                    errors.AddRange(ValidateCreateLessonPartRequest(part));

                    parts.Add(part);
                }

                if (errors.Any())
                {
                    return new CreateAllLessonPartResponse
                    {
                        Success = false,
                        ValidationErrors = errors
                    };
                }

                _repository.AddAll(request.ChapterCode, parts);

                return new CreateAllLessonPartResponse
                {
                    Success = true                 
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

                return new CreateAllLessonPartResponse
                {
                    Success = false,
                    ValidationErrors = validationFailures
                };
            }
            catch (Exception e)
            {
                return new CreateAllLessonPartResponse
                {
                    Success = false,
                    Exception = e
                };
            }
        }

        private List<ValidationFailure> ValidateCreateLessonPartRequest(Domain.Entity.LessonPart.LessonPart lessonPart)
        {
            List<ValidationFailure> errors = new List<ValidationFailure>();

            errors.AddRange(GetErrors(lessonPart, ValidationType.Add));

            var validator = new CreateLessonPartValidator(_repository, lessonPart);
            ValidationResult result = validator.Validate();

            errors.AddRange(result.Errors);

            return errors;
        }

        public UpdateAllPartsResponse Update(UpdateAllPartsRequest request)
        {
            try
            {
                List<ValidationFailure> errors = new List<ValidationFailure>();
                List<Domain.Entity.LessonPart.LessonPart> parts = new List<Domain.Entity.LessonPart.LessonPart>();

                foreach (var part in request.Parts)
                {
                    errors.AddRange(ValidateCreateLessonPartRequest(part));
                    parts.Add(part);
                }

                if (errors.Any())
                {
                    return new UpdateAllPartsResponse
                    {
                        Success = false,
                        ValidationFailures = errors
                    };
                }

                _repository.UpdateRange(request.ChapterCode, parts);

                return new UpdateAllPartsResponse
                {
                    Success = true,
                    Updated = parts
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

                return new UpdateAllPartsResponse
                {
                    Success = false,
                    ValidationFailures = validationFailures
                };
            }
            catch (Exception e)
            {
                return new UpdateAllPartsResponse
                {
                    Success = false,
                    Exception = e
                };
            }
        }
    }
}
