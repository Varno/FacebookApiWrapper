using Microsoft.Owin.Extensions;
using Owin;
using System.Web;
using System.Web.SessionState;

namespace FacebookApiWrapper.Web.Common
{

    /// <summary>
    /// AspNetSessionExtensions
    /// </summary>
    public static class AspNetSessionExtensions
    {
        public static IAppBuilder RequireAspNetSession(this IAppBuilder app)
        {
            app.Use((context, next) =>
            {
                HttpContextBase httpContext = context.Get<HttpContextBase>(typeof(HttpContextBase).FullName);
                httpContext.SetSessionStateBehavior(SessionStateBehavior.Required);
                return next();
            });
            app.UseStageMarker(PipelineStage.ResolveCache);
            return app;
        }
    }
}