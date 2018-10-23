using ASTEK.Architecture.ApplicationService.Entity.SubscribeActivity;
using System.Web.Mvc;

namespace ASTEK.Architecture.UI.MVC.Controllers
{
    public class SubscribeController : BaseController
    {
        [Authorize]
        public JsonResult SubscribeActivity(string accountId)
        {
            var toogleSubscribeInput = new ToogleSubscriptionInputModel
            {
                SubscribedId = accountId,
                SubscriberId = GetAccountLogged().Id.ToString()
            };

            var service = new SubscribeActivityAppService();
            var toogleSubscribeOutput = service.ToogleSubscription(toogleSubscribeInput);

            if (!toogleSubscribeOutput.Response.Success)
            {
                var result = new
                {
                    Success = false,
                    Exception = toogleSubscribeOutput.Response.Exception
                };

                return Json(result, JsonRequestBehavior.AllowGet);
            }
            else
            {
                var result = new
                {
                    Success = true,
                    IsSubscribed = toogleSubscribeOutput.Response.IsSubscribed
                };

                return Json(result, JsonRequestBehavior.AllowGet);
            }
        }
    }
}