using FacebookApiWrapper.Web.App_Start;
using Microsoft.Owin;
using Microsoft.Owin.Extensions;
using Microsoft.Owin.FileSystems;
using Microsoft.Owin.StaticFiles;
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

            app.UseFileServer(new FileServerOptions
            {
                FileSystem = new PhysicalFileSystem(".\\public"),
                RequestPath = new PathString("/public"),
            });
            app.UseWebApi(config);
            app.UseStageMarker(PipelineStage.MapHandler);
        }
    }
}