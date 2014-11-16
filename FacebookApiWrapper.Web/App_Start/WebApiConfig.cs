using Newtonsoft.Json.Serialization;
using System.Web.Http;

namespace FacebookApiWrapper.Web.App_Start
{
    public class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.MapHttpAttributeRoutes();
            config.Routes.MapHttpRoute(
                    name: "Default",
                    routeTemplate: "{controller}",
                    defaults: new { controller = "home" }
                );
            //var jsonFormatter = config.Formatters.JsonFormatter;
            //jsonFormatter.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
            //config.Formatters.Clear();
            //config.Formatters.Add(jsonFormatter);
        }
    }
}