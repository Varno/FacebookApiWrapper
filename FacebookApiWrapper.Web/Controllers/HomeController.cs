using System;
using System.Web.Http;

namespace FacebookApiWrapper.Web.Controllers
{
    public class HomeController : Nancy.NancyModule
    {
        //private static readonly Uri defaultUri = new Uri("/public/index.html", UriKind.Relative);

        public HomeController()
        {
            Get["/"] = _ =>
            {
                var model = new { AppId = Properties.Settings.Default.FacebookAppId };
                return View["index", model];
            };
        }
        //[Obsolete]
        //public IHttpActionResult Get()
        //{
        //    return Redirect(defaultUri);
        //}
    }
}
