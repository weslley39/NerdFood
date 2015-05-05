using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace NerdFood.Data.Repository.Dapper
{
    public class BaseReadOnlyRepository
    {
        public IDbConnection Connection
        {
            get
            {
                return new SqlConnection(ConfigurationManager.ConnectionStrings["NerdFoodContext"].ConnectionString);
            }
        }
    }
}
