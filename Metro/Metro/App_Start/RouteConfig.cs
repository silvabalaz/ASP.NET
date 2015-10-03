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
       name: "Distance",
       url: "Distance/distance",
       defaults: new { controller = "Distance", action = "distance", id = UrlParameter.Optional }
       );

         routes.MapRoute(
         name: "FormaUpload",
         url: "Home/Spremljeno",
         defaults: new { controller = "Home", action = "Upload", id = UrlParameter.Optional }
         );

   

        routes.MapRoute(
        name: "PregledRuta",
        url: "Home",
        defaults: new { controller = "Home", action = "PregledRuta", id = UrlParameter.Optional }
        );


        


            routes.MapRoute(
            name: "Ruta",
            url: "ObjektRuta/Details",
            defaults: new { controller = "DodajRutuIspisi", action = "Details", id = UrlParameter.Optional }
            );

            //probni , bitno je kojim redoslijedom su napisani 
            routes.MapRoute(
               name: "Unos",
               url: "U",
               defaults: new { controller = "Home", action = "Unos", id = UrlParameter.Optional }
           );

        

            routes.MapRoute(
            name: "Pocetna",
            url: "",
            defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
        );


            routes.MapRoute(
            name: "Default",
            url: "{controller}/{action}/{id}",
            defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
        );


        }
    }
}