using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NerdFood.Infra.CrossCutting.Identity;
using System.Data.Entity;

namespace NerdFood.Infra.Data.DbContexts
{
    public class IdentityContext : IdentityDbContext<AppIdentityUser>
    {        
        public IdentityContext()
            : base("NerdFoodContext")
        {
        }
    }
}
