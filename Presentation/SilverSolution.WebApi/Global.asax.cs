﻿using SilverSolution.AutofacIoC;
using SilverSolution.Core.DependencyResolve;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Routing;

namespace SilverSolution.WebApi
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);

            new DependencyResolve(new AutofacWebApi(typeof(WebApiApplication).Assembly, GlobalConfiguration.Configuration)).Bootstrap();
        }
    }
}
