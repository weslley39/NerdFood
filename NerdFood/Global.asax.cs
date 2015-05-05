using Microsoft.Practices.ServiceLocation;
using NerdFood.Data.Config;
using NerdFood.Domain.Interfaces.Infra;
using NerdFood.Presentation.Web.AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace NerdFood
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            AutoMapperConfig.RegisterMappings();
        }

        protected void Application_EndRequest()
        {
            var contextManager = ServiceLocator.Current.GetInstance<IContextManager>() as ContextManager;
            contextManager.NerdFoodContext.Dispose();
        }
    }
}
