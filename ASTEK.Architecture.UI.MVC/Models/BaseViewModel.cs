using ASTEK.Architecture.ApplicationService.Entity.Study;
using System.Configuration;
using System.Threading;

namespace ASTEK.Architecture.UI.MVC.Models
{
    public class BaseViewModel
    {
        private GetAllStudyOutputModel _studyOutputModel;

        public string BaseFileUrl
        {
            get { return ConfigurationManager.AppSettings.Get("BaseFileUrl"); }
        }

        public string ImageFolder
        {
            get { return ConfigurationManager.AppSettings.Get("ImageFolder"); }
        }

        public string AccountFolder
        {
            get { return ConfigurationManager.AppSettings.Get("AccountFolder"); }
        }

        public string StudyFolder
        {
            get { return ConfigurationManager.AppSettings.Get("StudyFolder"); }
        }


        public GetAllStudyOutputModel Studies
        {
            get
            {
                return _studyOutputModel ?? new StudyAppService().GetAll(new GetAllStudyInputModel { Culture = Thread.CurrentThread.CurrentCulture.Name });
            }
            set
            {
                _studyOutputModel = value;
            }
        }
    }
}