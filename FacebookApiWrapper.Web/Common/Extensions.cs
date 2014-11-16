﻿using Microsoft.Owin.Extensions;
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
                // Depending on the handler the request gets mapped to, session might not be enabled. Force it on.
                HttpContextBase httpContext = context.Get<HttpContextBase>(typeof(HttpContextBase).FullName);
                httpContext.SetSessionStateBehavior(SessionStateBehavior.Required);
                return next();
            });
            // SetSessionStateBehavior must be called before AcquireState
            app.UseStageMarker(PipelineStage.MapHandler);
            return app;
        }
    }
}