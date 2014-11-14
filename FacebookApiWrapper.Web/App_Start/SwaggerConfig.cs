using Swashbuckle.Application;
using System.Web.Http;

namespace FacebookApiWrapper.Web.App_Start
{
    public class SwaggerConfig
    {
        public static void Register(HttpConfiguration config)
        {
            Swashbuckle.Bootstrapper.Init(config);

            // NOTE: If you want to customize the generated swagger or UI, use SwaggerSpecConfig and/or SwaggerUiConfig here ...

            SwaggerSpecConfig.Customize(c =>
            {
                c.IgnoreObsoleteActions();
                c.IncludeXmlComments(GetXmlCommentsPath());
            });

            SwaggerUiConfig.Customize(c =>
            {
                c.SupportHeaderParams = false;
                c.DocExpansion = DocExpansion.List;

                //c.SupportedSubmitMethods = new[] { HttpMethod.Get, HttpMethod.Post, HttpMethod.Put, HttpMethod.Head };
                //c.InjectJavaScript(typeof(SwaggerConfig).Assembly, "Swashbuckle.TestApp.SwaggerExtensions.onComplete.js");
                //c.InjectStylesheet(typeof(SwaggerConfig).Assembly, "Swashbuckle.TestApp.SwaggerExtensions.customStyles.css");

                //c.CustomRoute("index.html", resourceAssembly, "Swashbuckle.TestApp.SwaggerExtensions.myIndex.html");
            });
        }

        protected static string GetXmlCommentsPath()
        {
            var result = System.String.Format(@"{0}\App_Data\WebApiDescription.xml", System.AppDomain.CurrentDomain.BaseDirectory);
            return result;
        }
    }
}