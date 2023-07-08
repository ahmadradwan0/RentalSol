using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Rental
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //Attribute Routing ...
            routes.MapMvcAttributeRoutes();



            //This is The old method not effecient cause if you change the action name its not going to chnage ..
            //Create custom route with more Parameters ,,,
            routes.MapRoute(
                name:"MoviesByReleaseDate",
                url:"movie/released/{year}/{month}",
                defaults:new { controller = "Movie",action = "ByReleaseDate", },
                new {year = @"\d{4}", month = @"\d{2}"}
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
