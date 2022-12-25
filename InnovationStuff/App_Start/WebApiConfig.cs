using System.Web.Http;
using Newtonsoft.Json.Serialization;

namespace InnovationStuff
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            var setting = GlobalConfiguration.Configuration.Formatters.JsonFormatter.SerializerSettings;
            setting.ContractResolver = new CamelCasePropertyNamesContractResolver();
            setting.Formatting = Newtonsoft.Json.Formatting.Indented;

            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
