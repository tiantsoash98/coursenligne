using ASTEK.Architecture.BusinessService.Entity.LessonChapter;
using ASTEK.Architecture.BusinessService.Interface;
using ASTEK.Architecture.Infrastructure.Specification;
using ASTEK.Architecture.Infrastructure.Utility;
using ASTEK.Architecture.Repository;
using ASTEK.Architecture.Repository.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ASTEK.Architecture.BusinessService.Entity.LessonFollowed
{
    public class LessonFollowedBusinessService : ILessonFollowedBusinessService
    {
        private readonly EFLessonFollowedRepository _repository;

        public LessonFollowedBusinessService()
        {
            var context = new EFDbContext();
            _repository = new EFLessonFollowedRepository(context);
        }

        public CountByAccountResponse CountByAccount(CountByAccountRequest request)
        {
            try
            {
                Expression<Func<Domain.Entity.LessonFollowed.LessonFollowed, bool>> expression = l => l.ACCID.Equals(request.AccountId);

                if (request.FromDate.HasValue)
                {
                    Expression<Func<Domain.Entity.LessonFollowed.LessonFollowed, bool>> fromDateExp = l => l.LSFDATE >= request.FromDate.Value;
                    expression = ExpressionUtilities.AndAlso(expression, fromDateExp);
                }
                if (request.ToDate.HasValue)
                {
                    Expression<Func<Domain.Entity.LessonFollowed.LessonFollowed, bool>> toDateExp = l => l.LSFDATE <= request.ToDate.Value;
                    expression = ExpressionUtilities.AndAlso(expression, toDateExp);
                }

                int count = _repository.Count(new Specification<Domain.Entity.LessonFollowed.LessonFollowed>(expression));

                return new CountByAccountResponse()
                {
                    Success = true,
                    Count = count
                };
            }
            catch (Exception ex)
            {
                return new CountByAccountResponse()
                {
                    Success = false,
                    Exception = ex
                };
            }
        }

        public CountByLessonResponse CountByLesson(CountByLessonRequest request)
        {
            try
            {
                Expression<Func<Domain.Entity.LessonFollowed.LessonFollowed, bool>> expression = l => l.LSNID.Equals(request.LessonId);

                if (request.FromDate.HasValue)
                {
                    Expression<Func<Domain.Entity.LessonFollowed.LessonFollowed, bool>> fromDateExp = l => l.LSFDATE >= request.FromDate.Value;
                    expression = ExpressionUtilities.AndAlso(expression, fromDateExp);
                }
                if (request.ToDate.HasValue)
                {
                    Expression<Func<Domain.Entity.LessonFollowed.LessonFollowed, bool>> toDateExp = l => l.LSFDATE <= request.ToDate.Value;
                    expression = ExpressionUtilities.AndAlso(expression, toDateExp);
                }

                int count = _repository.Count(new Specification<Domain.Entity.LessonFollowed.LessonFollowed>(expression));

                return new CountByLessonResponse()
                {
                    Success = true,
                    Count = count
                };
            }
            catch (Exception ex)
            {
                return new CountByLessonResponse()
                {
                    Success = false,
                    Exception = ex
                };
            }
        }

        public CountTotalViewsOfAccountResponse CountTotalViewsOfAccount(CountTotalViewsOfAccountRequest request)
        {
            try
            {
                Expression<Func<Domain.Entity.LessonFollowed.LessonFollowed, bool>> expression = l => l.Lesson.ACCID.Equals(request.AccountId);

                if (request.FromDate.HasValue)
                {
                    Expression<Func<Domain.Entity.LessonFollowed.LessonFollowed, bool>> fromDateExp = l => l.LSFDATE >= request.FromDate.Value;
                    expression = ExpressionUtilities.AndAlso(expression, fromDateExp);
                }
                if (request.ToDate.HasValue)
                {
                    Expression<Func<Domain.Entity.LessonFollowed.LessonFollowed, bool>> toDateExp = l => l.LSFDATE <= request.ToDate.Value;
                    expression = ExpressionUtilities.AndAlso(expression, toDateExp);
                }

                int count = _repository.Count(new Specification<Domain.Entity.LessonFollowed.LessonFollowed>(expression));

                return new CountTotalViewsOfAccountResponse
                {
                    Success = true,
                    Count = count
                };
            }
            catch (Exception ex)
            {
                return new CountTotalViewsOfAccountResponse
                {
                    Success = false,
                    Exception = ex
                };
            }
        }

        public FinishLessonResponse FinishLesson(FinishLessonRequest request)
        {
            try
            {
                _repository.FinishLesson(request.AccountId, request.LessonId, request.ChapterNumber, request.PartNumber);

                return new FinishLessonResponse()
                {
                    Success = true
                };
            }
            catch (Exception ex)
            {
                return new FinishLessonResponse()
                {
                    Success = false,
                    Exception = ex
                };
            }
        }

        public FinishPartResponse FinishPart(FinishPartRequest request)
        {
            try
            {
                _repository.FinishPart(request.AccountId, request.LessonId, request.ChapterNumber, request.PartNumber);

                return new FinishPartResponse()
                {
                    Success = true
                };
            }
            catch (Exception ex)
            {
                return new FinishPartResponse()
                {
                    Success = false,
                    Exception = ex
                };
            }
        }

        public FollowLessonResponse Follow(FollowLessonRequest request)
        {
            try
            {
                _repository.Follow(request.AccountId, request.LessonId);

                return new FollowLessonResponse()
                {
                    Success = true
                };
            }
            catch(Exception ex)
            {
                return new FollowLessonResponse()
                {
                    Success = false,
                    Exception = ex
                };
            }
        }

        public GetByLessonResponse GetByLesson(GetByLessonRequest request)
        {
            try
            {
                var follows = _repository.GetByLesson(request.LessonId);

                return new GetByLessonResponse
                {
                    Success = true,
                    Followers = follows
                };
            }
            catch(Exception ex)
            {
                return new GetByLessonResponse
                {
                    Success = false,
                    Exception = ex
                };
            }
        }

        public GetFollowedByResponse GetFollowedBy(GetFollowedByRequest request)
        {
            try
            {
                var followed = _repository.GetFollowedBy(request.AccountId);

                int totalPages = ListUtilities.GetTotalPagesCount(followed.Count, request.Count);

                List<Domain.Entity.LessonFollowed.LessonFollowed> pagedList = followed.OrderByDescending(l => l.LSFDATE)
                                                                                        .Skip((request.Page - 1) * request.Count)
                                                                                        .Take(request.Count)
                                                                                        .ToList();

                return new GetFollowedByResponse()
                {
                   Success = true,
                   Followed = pagedList,
                   Page = request.Page,
                   Count = request.Count,
                   TotalPages = totalPages
                };
            }
            catch(Exception ex)
            {
                return new GetFollowedByResponse()
                {
                    Success = false,
                    Exception = ex
                };
            }
        }
    }
}
