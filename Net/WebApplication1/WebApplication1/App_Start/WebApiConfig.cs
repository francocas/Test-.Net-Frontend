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

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "MyRestFullApp/{controller}/{currency}",
                defaults: new
                {
                    currency = RouteParameter.Optional
                });
            #region Users
            config.MapHttpAttributeRoutes();
            config.Routes.MapHttpRoute(
                name: "GetOneUser",
                routeTemplate: "MyRestFullApp/{controller}/{action}/{id}",
                defaults: new
                {
                    id = RouteParameter.Optional
                });
            config.Routes.MapHttpRoute(
                name: "DeleteUserById",
                routeTemplate: "MyRestFullApp/{controller}/{action}/{id}",
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
            #endregion



        }
    }
}
