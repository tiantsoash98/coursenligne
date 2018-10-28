using ASTEK.Architecture.BusinessService.Entity.Lesson;
using ASTEK.Architecture.BusinessService.Interface;
using ASTEK.Architecture.Infrastructure.Domain;
using ASTEK.Architecture.Infrastructure.Specification;
using ASTEK.Architecture.Infrastructure.Utility;
using ASTEK.Architecture.Repository;
using ASTEK.Architecture.Repository.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Mail;
using System.Text;

namespace ASTEK.Architecture.BusinessService.Entity.SubscribeActivity
{
    public class SubscribeActivityBusinessService: ISubscribeActivityBusinessService
    {
        private readonly EFSubscribeActivityRepository _repository;

        public SubscribeActivityBusinessService()
        {
            var context = new EFDbContext();
            _repository = new EFSubscribeActivityRepository(context);
        }

        public CountSubscribersResponse CountSubscribers(CountSubscribersRequest request)
        {
            try
            {
                Expression<Func<Domain.Entity.SubscribeActivity.SubscribeActivity, bool>> findById = s => s.ACCSUBSCRIBED.Equals(request.AccountId);

                int count = _repository.Count(new Specification<Domain.Entity.SubscribeActivity.SubscribeActivity>(findById));

                return new CountSubscribersResponse
                {
                    Success = true,
                    Count = count 
                };
            }
            catch (Exception ex)
            {
                return new CountSubscribersResponse
                {
                    Success = true,
                    Exception = ex
                };
            }
        }

        public GetAllSubscribedResponse GetAllSubscribed(GetAllSubscribedRequest request)
        {
            try
            {
                var subscribed = _repository.GetAllSubscribed(request.AccountId);

                int totalPages = ListUtilities.GetTotalPagesCount(subscribed.Count, request.Count);

                List<Domain.Entity.SubscribeActivity.SubscribeActivity> pagedList = subscribed.OrderByDescending(s => s.SUBDATE)
                                                                                                .Skip((request.Page - 1) * request.Count)
                                                                                                .Take(request.Count)
                                                                                                .ToList();

                return new GetAllSubscribedResponse
                {
                    Success = true,
                    Subscribed = pagedList,
                    Count = request.Count,
                    TotalPages = totalPages
                };
            }
            catch (Exception ex)
            {
                return new GetAllSubscribedResponse
                {
                    Success = false,
                    Exception = ex
                };
            }
        }

        public GetAllSubscribersResponse GetAllSubscribers(GetAllSubscribersRequest request)
        {
            try
            {
                var subscribers = _repository.GetAllSubscribers(request.AccountId);

                int totalPages = ListUtilities.GetTotalPagesCount(subscribers.Count, request.Count);

                List<Domain.Entity.SubscribeActivity.SubscribeActivity> pagedList = subscribers.OrderByDescending(s => s.SUBDATE)
                                                                                                .Skip((request.Page - 1) * request.Count)
                                                                                                .Take(request.Count)
                                                                                                .ToList();

                return new GetAllSubscribersResponse
                {
                    Success = true,
                    Subscribers = pagedList,
                    Count = request.Count,
                    TotalPages = totalPages
                };
            }
            catch (Exception ex)
            {
                return new GetAllSubscribersResponse
                {
                    Success = false,
                    Exception = ex
                };
            }
        }

        public IsSubscribedResponse IsSubscribed(IsSubscribedRequest request)
        {
            try
            {
                bool isSubscribed = _repository.IsSubscribedTo(request.SubscriberId, request.SubscribedId);

                return new IsSubscribedResponse
                {
                    Success = true,
                    IsSubscribed = isSubscribed
                };
            }
            catch (Exception ex)
            {
                return new IsSubscribedResponse
                {
                    Success = false,
                    Exception = ex
                };
            }
        }

        public NotifySubscribersResponse NotifySubscribers(NotifySubscribersRequest request)
        {
            try
            {
                var lessonRequest = new GetLessonRequest
                {
                    LessonId = request.LessonId
                };

                var lessonOutput = new LessonBusinessService().Get(lessonRequest);

                if (!lessonOutput.Success)
                {
                    throw lessonOutput.Exception;
                }

                var subscribers = _repository.GetAllSubscribers(request.AccountId);

                var mail = new MailMessage();
                subscribers.ForEach(x =>  mail.To.Add(x.Subscriber.ACCEMAIL));

                var lesson = lessonOutput.Lesson;
                var teacher = lesson.Account.AccountTeachers.FirstOrDefault();

                string name = teacher.ACTNAME;
                string firstName = teacher.ACTFIRSTNAME;
                string study = lesson.Study.STDNAME;
                string title = lesson.LSNTITLE;
                string link = request.UrlPath;
                string appTitle = "Estudia";

                if (request.NotificationSource == NotificationSource.Publish)
                {         
                    mail.Subject = string.Format("Nouveau cours publié par {0} {1}", firstName, name);

                    var sb = new StringBuilder();
                    sb.AppendLine("{0} {1} vient de publier un nouveau cours, sur la filière {2}, intitulé: \"{3}\".");
                    sb.AppendLine("Accédez rapidement au cours via ce lien: {4}");
                    sb.AppendLine("");
                    sb.AppendLine("{5} - Plateforme de cours en ligne");

                    mail.Body = string.Format(sb.ToString(), firstName, name, study, title, link, appTitle);

                    MailUtilities.SendMail(mail);
                }

                return new NotifySubscribersResponse
                {
                    Success = true
                };
            }
            catch(Exception ex)
            {
                return new NotifySubscribersResponse
                {
                    Success = false,
                    Exception = ex
                };
            } 
        }

        public ToogleSubscriptionResponse ToogleSubscription(ToogleSubscriptionRequest request)
        {
            try
            {
                bool isSubscribed = _repository.IsSubscribedTo(request.SubscriberId, request.SubscribedId);

                if (isSubscribed)
                {
                    _repository.Unsubscribe(request.SubscriberId, request.SubscribedId);
                }
                else
                {
                    _repository.Subscribe(request.SubscriberId, request.SubscribedId);
                }

                return new ToogleSubscriptionResponse
                {
                    Success = true,
                    IsSubscribed = !isSubscribed
                };
            }
            catch (Exception ex)
            {
                return new ToogleSubscriptionResponse
                {
                    Success = false,
                    Exception = ex
                };
            }
        }
    }
}
