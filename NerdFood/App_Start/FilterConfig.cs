using NerdFood.Infra.CrossCutting.MvcFilters;
using System.Web.Mvc;

namespace NerdFood
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new UserInformationAttribute());        
        }
    }
}
