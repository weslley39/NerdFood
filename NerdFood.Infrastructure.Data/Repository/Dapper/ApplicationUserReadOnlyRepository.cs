using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NerdFood.Domain.Entities;
using NerdFood.Domain.Interfaces.Repository;

using Dapper;
using NerdFood.Domain;
using System.Data;

namespace NerdFood.Data.Repository.Dapper
{
    public class ApplicationUserReadOnlyRepository : BaseReadOnlyRepository, IApplicationUserReadOnlyRepository
    {
        public ApplicationUser GetById(string id)
        {
            using (IDbConnection cn = Connection)
            {
                cn.Open();

                var appUser = cn.Query<ApplicationUser>("SELECT * FROM AspNetUsers WHERE Id=@AppUserId", new { AppUserId = id }).FirstOrDefault();

                return appUser;
            }
        }
        
        public IEnumerable<ApplicationUser> Find(System.Linq.Expressions.Expression<Func<ApplicationUser, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        ApplicationUser IReadOnlyRepository<ApplicationUser>.GetById(long id)
        {
            throw new NotImplementedException();
        }

        IEnumerable<ApplicationUser> IReadOnlyRepository<ApplicationUser>.All()
        {
            throw new NotImplementedException();
        }
    }
}
