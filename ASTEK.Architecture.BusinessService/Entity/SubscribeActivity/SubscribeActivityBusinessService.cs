using ASTEK.Architecture.BusinessService.Entity.Lesson;
using ASTEK.Architecture.BusinessService.Interface;
using ASTEK.Architecture.Infrastructure.Domain;
using ASTEK.Architecture.Infrastructure.Utility;
using ASTEK.Architecture.Repository;
using ASTEK.Architecture.Repository.Concrete;
using System;
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
                subscribers.ForEach(x => mail.To.Add(x.Subscriber.ACCEMAIL));

                string name = "";
                string firstName = "";
                string study = "";
                string title = "";
                string link = "";
                string appTitle = "";

                if (request.NotificationSource == NotificationSource.Publish)
                {         
                    mail.Subject = string.Format("Nouveau cours publié par {0} {1}", firstName, name);

                    var sb = new StringBuilder();
                    sb.AppendLine("{0} {1} vient de publier un nouveau cours, sur la filière {2}, intitulé: \"{3}\".");
                    sb.AppendLine("Cliquer <a href=\"{4}\">ici</> pour voir le cours");
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
    }
}
