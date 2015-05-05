using System.Web;
using NerdFood.Domain.Interfaces.Infra;
using NerdFood.Infra.Data.DbContexts;

namespace NerdFood.Data.Config
{
    public class ContextManager : IContextManager
    {
        public const string HttpNerdFoodContext = "HttpNerdFoodContext";

        public NerdFoodContext NerdFoodContext
        {
            get
            {
                if (HttpContext.Current.Items[HttpNerdFoodContext] == null)
                {
                    HttpContext.Current.Items[HttpNerdFoodContext] = new NerdFoodContext();
                }
                return HttpContext.Current.Items[HttpNerdFoodContext] as NerdFoodContext;
            }
        }

        public void Finish()
        {
            if (HttpContext.Current.Items[HttpNerdFoodContext] != null)
            {
                (HttpContext.Current.Items[HttpNerdFoodContext] as NerdFoodContext).Dispose();
            }
        }
    }
}
