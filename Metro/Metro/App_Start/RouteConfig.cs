using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Metro
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");


    

       routes.MapRoute(
   name: "zg1",
   url: "zagrebmetro/zagrebPost",
   defaults: new { controller = "zagrebmetro", action = "zagrebPost", id = UrlParameter.Optional }
   );

       routes.MapRoute(
     name: "zg",
     url: "zagrebmetro/zagreb",
     defaults: new { controller = "zagrebmetro", action = "zagreb", id = UrlParameter.Optional }
     );
     

         routes.MapRoute(
         name: "metro3",
         url: "zagreb-metro/trip/round/count",
         defaults: new { controller = "METRO-3", action = "metro3", id = UrlParameter.Optional }
         );

         routes.MapRoute(
                  name: "metro4",
                  url: "zagreb-metro/trip/count",
                  defaults: new { controller = "METRO-4", action = "metro4", id = UrlParameter.Optional }
                  );

         routes.MapRoute(
      name: "metro5",
      url: "zagreb-metro/trip/shortest",
      defaults: new { controller = "METRO-5", action = "metro5", id = UrlParameter.Optional }
      );

         routes.MapRoute(
     name: "metro7",
     url: "zagreb-metro/trip/bonus",
     defaults: new { controller = "METRO-7", action = "metro7", id = UrlParameter.Optional }
     );
            routes.MapRoute(
            name: "Default",
            url: "{controller}/{action}/{id}",
            defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
        );


        }
    }
}