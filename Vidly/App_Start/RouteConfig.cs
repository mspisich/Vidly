using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Vidly
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapMvcAttributeRoutes();

            //routes.MapRoute(
            //    name: "MoviesByReleaseDate",
            //    url: "movies/released/{year}/{month}",
            //    defaults: new { controller = "Movies", action = "ByReleaseDate" },
            //    //new { year = @"\d{4}", month = @"\d{2}" } //Sets constraint for 4 and 2 characters for these parameters (will throw 404 if url does not fit with this)
            //    new { year = @"2014|2015", month = @"\d{2}" } //Only allows 2014 and 2015 for the year parameter
            //);

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
