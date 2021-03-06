﻿using SilverSolution.AutofacIoC;
using SilverSolution.Core.DependencyResolve;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace SilverSolution.WebMvc
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
         
            new DependencyResolve(new AutofacMvc(typeof(MvcApplication).Assembly)).Bootstrap();
        }
    }
}
