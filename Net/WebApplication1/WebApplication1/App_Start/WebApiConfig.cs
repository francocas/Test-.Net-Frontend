using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace WebApplication1
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Configuración y servicios de API web

            // Rutas de API web
            config.MapHttpAttributeRoutes();
            config.Routes.MapHttpRoute(
                name: "GetOneUser",
                routeTemplate: "MyRestFullApp/{controller}/{id}",
                defaults: new
                {
                    id = RouteParameter.Optional
                });
            config.Routes.MapHttpRoute(
                name: "DeleteUserById",
                routeTemplate: "MyRestFullApp/{controller}/{id}",
                defaults: new
                {
                    action = "Delete",
                    id = RouteParameter.Optional
                });
            config.Routes.MapHttpRoute(
                name: "UpdateUser",
                routeTemplate: "MyRestFullApp/{controller}/{action}",
                defaults: new
                {
                    action = "Put",
                });

            config.Routes.MapHttpRoute(
                name: "InsertUser",
                routeTemplate: "MyRestFullApp/{controller}/{action}",
                defaults: new
                {
                    action = "Post",
                });
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "MyRestFullApp/{controller}/{currency}",
                defaults: new
                {
                    currency = RouteParameter.Optional
                });

        }
    }
}
