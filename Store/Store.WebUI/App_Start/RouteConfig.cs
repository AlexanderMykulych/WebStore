﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Store.WebUI
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {

            routes.MapRoute(
                "CartRoute",
                "Order/{id}",
                new { controller = "Cart", action = "Cart", id = -1});

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{categories}/{pageId}",
                defaults: new { controller = "Home", action = "Index", categories = "All", pageId = 1}
            );
        }
    }
}