using FacebookApiWrapper.Web.App_Start;
using Microsoft.Owin;
using Microsoft.Owin.Extensions;
using Owin;
using System.Web.Http;

namespace FacebookApiWrapper.Web
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var config = new HttpConfiguration();
            SwaggerConfig.Register(config);
            WebApiConfig.Register(config);

            app.UseWebApi(config);
            app.UseStageMarker(PipelineStage.MapHandler);
        }
    }
}