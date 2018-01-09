using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

using Ninject;
using Ninject.Web.Common.WebHost;
using _60321_2_Severina.Services;
using CAR.Interfaces;
using CAR.Entities;
using CAR.Repositories;

namespace _60321_2_Severina
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapRoute(
                name: "",
                url: "Car",
                defaults: new
                {
                    controller = "Car",
                    action = "List",
                    page = 1,
                    group = (string)null
                });
            routes.MapRoute(
                name: "",
                url: "Car/page{page}",
                defaults: new
                {
                 controller = "Car",
                 action = "List",
                 group = (string)null
                },
                constraints: new { page = @"\d+" });

            routes.MapRoute(
                 name: "",
                 url: "Car/{group}",
                 defaults: new
                {
                controller = "Car",
                action = "List",
                page = 1
                 });
            routes.MapRoute(
                name: "",
                url: "Car/{group}/page{page}",
                defaults: new { controller = "Car", action = "List" },
                constraints: new { page = @"\d+" });
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }

    }
}
