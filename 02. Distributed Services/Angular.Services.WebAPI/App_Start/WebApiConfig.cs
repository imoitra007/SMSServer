using System.Web.Http;
using System.Web.Http.Cors;
using SMS.Services.WebAPI.ActionFilters;

namespace SMS.Services.WebAPI
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();
            
            var cors = new EnableCorsAttribute("*","*","*");
            config.EnableCors(cors);

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{action}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            config.Formatters.Remove(config.Formatters.XmlFormatter);
            config.Formatters.JsonFormatter.SupportedMediaTypes.Add(new
                System.Net.Http.Headers.MediaTypeHeaderValue("application/json"));

            config.Filters.Add(new LoggingFilterAttribute());
            config.Filters.Add(new GlobalExceptionAttribute());
        }
    }
}
