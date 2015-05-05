using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NerdFood.Domain.Interfaces.Infra;

namespace NerdFood.Infra.CrossCutting.Identity
{
    public class AppIdentityUser : IdentityUser, IAppUser
    {
        public string Name { get; set; }

        public string Lastname { get; set; }

        public string FullName()
        {
            return Name + " " + Lastname;
        }
    }
}
