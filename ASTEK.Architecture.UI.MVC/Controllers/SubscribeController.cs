using ASTEK.Architecture.ApplicationService.Entity.SubscribeActivity;
using ASTEK.Architecture.UI.MVC.Models.SubscribeActivity;
using System.Web.Mvc;

namespace ASTEK.Architecture.UI.MVC.Controllers
{
    public class SubscribeController : BaseController
    {
        [Authorize]
        public JsonResult ToogleSubscription(string accountId)
        {
            string subscriberId = GetAccountLogged().Id.ToString();
            string subscribedId = accountId;

            var toogleSubscribeInput = new ToogleSubscriptionInputModel
            {
                SubscribedId = subscribedId,
                SubscriberId = subscriberId
            };

            var service = new SubscribeActivityAppService();
            var toogleSubscribeOutput = service.ToogleSubscription(toogleSubscribeInput);

            if (!toogleSubscribeOutput.Response.Success)
            {
                var resultVM = new ToogleSubscriptionViewModel
                {
                    Success = false,
                    Exception = toogleSubscribeOutput.Response.Exception,
                    SubscribedId = subscribedId,
                    SubscriberId = subscriberId
                };

                return Json(resultVM, JsonRequestBehavior.AllowGet);
            }
            else
            {
                var resultVM = new ToogleSubscriptionViewModel
                {
                    Success = true,
                    SubscribedId = subscribedId,
                    SubscriberId = subscriberId,
                    IsSubscribed = toogleSubscribeOutput.Response.IsSubscribed
                };

                return Json(resultVM, JsonRequestBehavior.AllowGet);
            }
        }

        [Authorize]
        public PartialViewResult Subscribe(string accountId)
        {
            string subscriberId = GetAccountLogged().Id.ToString();

            var input = new IsSubscribedInputModel
            {
                SubscriberId = subscriberId,
                SubscribedId = accountId
            };

            var service = new SubscribeActivityAppService();
            var output = service.IsSubscribed(input);

            var subscribeVM = new SubscribeButtonViewModel
            {
                SubscribedId = accountId,
                SubscriberId = subscriberId,
                IsSubscribed = output.Response.IsSubscribed
            };
       
            return PartialView("_SubscribeButton", subscribeVM);
        }
    }
}