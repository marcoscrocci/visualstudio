using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace Projeto01_IntroducaoWebAPI
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Serviços e configuração da API da Web

            // Rotas da API da Web
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            // Removemos a convenção XML
            config.Formatters.Remove(config.Formatters.XmlFormatter);

            // Adiciona a convenção JSON
            config.Formatters.Add(config.Formatters.JsonFormatter);
            
        }
    }
}
