using System.Linq;
using System.Security.Claims;
using System.Web.Http.Filters;
using System.Web.Mvc.Filters;

namespace NerdFood.Infra.CrossCutting.MvcFilters
{
    public class UserInformationAttribute : FilterAttribute, IAuthenticationFilter
    {
        public void OnAuthentication(AuthenticationContext filterContext)
        {
            var identity = (ClaimsIdentity)filterContext.Principal.Identity;

            var UserFullName = identity.Claims.Where(c => c.Type == "UserFullName").FirstOrDefault();
            if (UserFullName != null)
            {
                filterContext.Controller.ViewBag.UserFullName = UserFullName.Value;
            }
        }

        public void OnAuthenticationChallenge(AuthenticationChallengeContext filterContext)
        {
            // Nothing
        }
    }
}
