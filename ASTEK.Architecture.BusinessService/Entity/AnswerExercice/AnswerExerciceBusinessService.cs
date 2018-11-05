using ASTEK.Architecture.BusinessService.Abstract;
using ASTEK.Architecture.BusinessService.Interface;
using ASTEK.Architecture.Infrastructure.Domain;
using ASTEK.Architecture.Infrastructure.Utility;
using ASTEK.Architecture.Repository;
using ASTEK.Architecture.Repository.Concrete;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ASTEK.Architecture.BusinessService.Entity.AnswerExercice
{
    public class AnswerExerciceBusinessService : EntityServiceBase<Domain.Entity.AnswerExercice.AnswerExercice>, IAnswerExerciceBusinessService
    {
        private readonly EFAnswerExerciceRepository _repository;

        public AnswerExerciceBusinessService()
        {
            var context = new EFDbContext();
            _repository = new EFAnswerExerciceRepository(context);
        }

        public CorrectAnswerResponse Correct(CorrectAnswerRequest request)
        {
            try
            {
                var answer = _repository.FindBy(request.AnswerId);

                if (answer == null)
                {
                    throw new InvalidOperationException();
                }

                answer.ANSISCORRECTED = true;
                answer.ANSDATECORRECTION = DateTime.Now;
                answer.ANSCOMMENTCORRECTION = request.Comment;
                answer.ANSMARK = request.Mark;
                answer.ANSVALUATION = request.Valuation;

                _repository.Save(answer);

                return new CorrectAnswerResponse
                {
                    Corrected = answer,
                    Success = true
                };
            }
            catch (Exception e)
            {
                return new CorrectAnswerResponse
                {
                    Success = false,
                    Exception = e
                };
            }
        }

        public CountAnswerResponse Count(CountAnswerRequest request)
        {
            try
            {
                int count = 0;

                if (request.Type.Equals("Teacher"))
                {
                    if (request.Marked)
                    {
                        count = _repository.CountMarkedTeacher(request.AccountId, request.LessonId);
                    }
                    else
                    {
                        count = _repository.CountUnmarkedTeacher(request.AccountId, request.LessonId);
                    }
                }
                else
                {
                    if (request.Marked)
                    {
                        count = _repository.CountMarkedStudent(request.AccountId);
                    }
                    else
                    {
                        count = _repository.CountUnmarkedStudent(request.AccountId);
                    }
                }


                return new CountAnswerResponse
                {
                    Type = request.Type,
                    Count = count,
                    Marked = request.Marked,
                    Success = true
                };
            }
            catch (Exception e)
            {
                return new CountAnswerResponse
                {
                    Exception = e,
                    Success = false
                };
            }
        }

        public GetAnswerExerciceResponse Get(GetAnswerExerciceRequest request)
        {
            try
            {             
                var result = _repository.FindBy(request.AnswerId);

                return new GetAnswerExerciceResponse
                {
                    AnswerExercice = result,
                    Success = true
                };
            }
            catch (Exception ex)
            {
                return new GetAnswerExerciceResponse
                {
                    Success = false,
                    Exception = ex
                };
            }
        }

        public GetAllResponse GetAll(GetAllRequest request)
        {
            try
            {
                List<Domain.Entity.AnswerExercice.AnswerExercice> answerExercices = null;

                if (request.Type.Equals("Teacher"))
                {
                    if (request.Marked)
                    {
                        answerExercices = _repository.GetAllMarkedTeacher(request.AccountId, request.LessonId);
                    }
                    else
                    {
                        answerExercices = _repository.GetAllUnmarkedTeacher(request.AccountId, request.LessonId);
                    }
                }
                else
                {
                    if (request.Marked)
                    {
                        answerExercices = _repository.GetAllMarkedStudent(request.AccountId);
                    }
                    else
                    {
                        answerExercices = _repository.GetAllUnmarkedStudent(request.AccountId);
                    }
                }

                int totalPages = ListUtilities.GetTotalPagesCount(answerExercices.Count, request.Count);

                List<Domain.Entity.AnswerExercice.AnswerExercice> pagedList = answerExercices.OrderByDescending(l => l.ANSDATEPOSTED)
                                                                                .Skip((request.Page - 1) * request.Count)
                                                                                .Take(request.Count)
                                                                                .ToList();

                return new GetAllResponse
                {
                    AnswerExercices = pagedList,
                    Type = request.Type,
                    TotalPages = totalPages,
                    Count = request.Count,
                    Marked = request.Marked,
                    Success = true
                };
            }
            catch (Exception ex)
            {
                return new GetAllResponse
                {
                    Success = false,
                    Exception = ex
                };
            }
        }

        public override List<ValidationFailure> GetErrors(Domain.Entity.AnswerExercice.AnswerExercice entity, ValidationType validationType)
        {
            throw new NotImplementedException();
        }

        public GetMarksOfStudentResponse GetMarksOfStudent(GetMarksOfStudentRequest request)
        {
            try
            {
                var marks = _repository.GetMarksOfStudent(request.AccountId, request.StudyCode, request.Level);

                return new GetMarksOfStudentResponse
                {
                    MarksList = marks,
                    Success = true
                };
            }
            catch (Exception ex)
            {
                return new GetMarksOfStudentResponse
                {
                    Success = false,
                    Exception = ex
                };
            }
        }

        public HasPostedResponse HasPosted(HasPostedRequest request)
        {
            try
            {
                var result = _repository.HasPosted(request.AccountId, request.LessonId);

                return new HasPostedResponse
                {
                    HasPosted = result,
                    Success = true
                };
            }
            catch (Exception ex)
            {
                return new HasPostedResponse
                {
                    Success = false,
                    Exception = ex
                };
            }
        }

        public UploadAnswerResponse Upload(UploadAnswerRequest request)
        {
            try
            {
                var answer = new Domain.Entity.AnswerExercice.AnswerExercice
                {
                    ACCID = request.AccountId,
                    LSNID = request.LessonId,
                    ANSCOMMENT = request.Comment,
                    ANSDATEPOSTED = DateTime.Now,
                    ANSFILE = request.FileName,
                    ANSISCORRECTED = false
                };

                var result = _repository.Upload(answer);

                return new UploadAnswerResponse
                {
                    AnswerExercice = result,
                    Success = true
                };
            }
            catch(Exception ex)
            {
                return new UploadAnswerResponse
                {
                    Success = false,
                    Exception = ex
                };
            }
        }
    }
}
