using Facebook;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Http.Description;

namespace FacebookApiWrapper.Web.Controllers
{
    [RoutePrefix("api")]
    public class FacebookController : ApiController
    {
        private static readonly Uri apiDescriptionUri = new Uri("/../swagger/ui/index.html", UriKind.Relative);

        /// <summary>
        /// Token Model
        /// </summary>
        public class TokenModel
        {
            public string AccessToken { get; set; }
        }

        public FacebookController()
        {
          int x = 1;
        }
        /// <summary>
        /// Register facebook token on the server.
        /// </summary>
        /// <param name="model">Facebook access token model.</param>
        /// <returns></returns>
        [Obsolete]
        [HttpPost]
        [Route("RegisterToken")]
        public IHttpActionResult Post(TokenModel model)
        {
            string longLivedToken;
            try
            {
                longLivedToken = GetExtendedAccessToken(model.AccessToken);
                HttpContext.Current.Session["facebookToken"] = longLivedToken;
                return Redirect(apiDescriptionUri);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        private string GetExtendedAccessToken(string shortLivedToken)
        {
            FacebookClient client = new FacebookClient();
            string extendedToken = "";
            try
            {
                dynamic result = client.Get("/oauth/access_token", new
                {
                    grant_type = "fb_exchange_token",
                    client_id = Properties.Settings.Default.FacebookAppId,
                    client_secret = Properties.Settings.Default.FacebookAppSecret,
                    fb_exchange_token = shortLivedToken
                });
                extendedToken = result.access_token;
            }
            catch
            {
                extendedToken = shortLivedToken;
            }
            return extendedToken;
        }

        /// <summary>
        /// Get facebook friend list
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("FriendList")]
        public IHttpActionResult GetFriends()
        {
            string longLivedToken = HttpContext.Current.Session["facebookToken"] as string;
            try
            {
                var client = new FacebookClient(longLivedToken);
                var result = client.Get("me/friends");
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
