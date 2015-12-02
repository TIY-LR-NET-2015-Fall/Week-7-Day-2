using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace week7day2
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
               name: "WallMessage",
               url: "wall/{name}/{message}",
               defaults: new { controller = "classmates", action = "PostWallMessage", name = "", message = ""}
           );

            routes.MapRoute(
               name: "StudentList",
               url: "students",
               defaults: new { controller = "classmates", action = "List", id = UrlParameter.Optional }
           );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
