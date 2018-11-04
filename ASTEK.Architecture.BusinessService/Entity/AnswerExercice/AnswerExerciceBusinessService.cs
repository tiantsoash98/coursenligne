using ASTEK.Architecture.BusinessService.Abstract;
using ASTEK.Architecture.BusinessService.Interface;
using ASTEK.Architecture.Infrastructure.Domain;
using ASTEK.Architecture.Repository;
using ASTEK.Architecture.Repository.Concrete;
using FluentValidation.Results;
using System;
using System.Collections.Generic;

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

        public override List<ValidationFailure> GetErrors(Domain.Entity.AnswerExercice.AnswerExercice entity, ValidationType validationType)
        {
            throw new NotImplementedException();
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
