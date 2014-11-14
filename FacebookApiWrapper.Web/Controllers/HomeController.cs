using System;
using System.Web.Http;

namespace FacebookApiWrapper.Web.Controllers
{
    public class HomeController : ApiController
    {
        private static readonly Uri defaultUri = new Uri("swagger/ui/index.html", UriKind.Relative);
        
        [Obsolete]
        public IHttpActionResult Get()
        {
            return Redirect(defaultUri);
        }
    }
}
