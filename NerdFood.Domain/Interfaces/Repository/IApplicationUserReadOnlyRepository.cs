using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using NerdFood.Domain.Entities;

namespace NerdFood.Domain.Interfaces.Repository
{
    public interface IApplicationUserReadOnlyRepository : IReadOnlyRepository<ApplicationUser>
    {
        ApplicationUser GetById(string Id);
    }
}
