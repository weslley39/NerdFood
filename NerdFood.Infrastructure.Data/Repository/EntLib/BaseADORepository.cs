using Microsoft.Practices.EnterpriseLibrary.Data;

namespace NerdFood.Data.Repository.EntLib
{
    public class BaseADORepository
    {
        public Database Connection
        {
            get
            {
                return new DatabaseProviderFactory().Create("NerdFoodContext");
            }
        }
    }        
}
