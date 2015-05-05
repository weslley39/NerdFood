using System.Web;
using System.Web.Mvc.Filters;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;

using NerdFood.Application.Interfaces;
using NerdFood.Domain;
using NerdFood.Domain.Entities;

namespace NerdFood.Infra.CrossCutting.MvcFilters
{
    public class UserDataCacheFilter : IAuthenticationFilter
    {
        private IApplicationUserAppService _applicationUserAppService;
        private ApplicationUser AppUser;
        private HttpContextBase BaseContext;

        public UserDataCacheFilter(IApplicationUserAppService ApplicationUserAppService)
        {
            this._applicationUserAppService = ApplicationUserAppService;
        }

        public void OnAuthentication(AuthenticationContext filterContext)
        {
            BaseContext = filterContext.HttpContext;
            //filterContext.Controller.ViewBag.UserFullName = GetUserFullName();
        }

        private void StoreUserData()
        {
            AppUser = BaseContext.Cache["UserData" + BaseContext.User.Identity.GetUserId()] as ApplicationUser;

            if (AppUser == null)
            {
                AppUser = _applicationUserAppService.ObterPorID(BaseContext.User.Identity.GetUserId());

                if (AppUser != null)
                    BaseContext.Cache["UserData" + AppUser.Id] = AppUser;
            }
        }

        private bool IsAuthenticated()
        {
            if (BaseContext != null && BaseContext.User.Identity.IsAuthenticated)
            {
                StoreUserData();
                return true;
            }
            return false;
        }

        private string GetUserFullName()
        {
            if (IsAuthenticated())
            {
                if (AppUser != null)
                    return AppUser.FullName();
            }

            return "";
        }

        public void OnAuthenticationChallenge(AuthenticationChallengeContext filterContext)
        {
        }
    }

    public class UserDataCacheAttribute : FilterAttribute
    {
        // Attribute used by filter above, just due attributes not accept DI from Ninject
    }
}
