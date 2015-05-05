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
    public class ClienteReadOnlyRepository : BaseReadOnlyRepository, IClienteReadOnlyRepository
    {
        public Cliente GetById(long id)
        {
            using (IDbConnection cn = Connection)
            {
                cn.Open();

                var cliente = cn.Query<Cliente>("SELECT * FROM CLIENTE WHERE CLIENTEID=@ClienteId", new { ClienteId = id }).FirstOrDefault();
                if (cliente != null)
                {
                    //cliente.PublicacaoList = cn.Query<Publicacao>("SELECT * FROM PUBLICACAO WHERE CLIENTEID IN ( " + cliente.ClienteId + ")").ToList();
                }

                return cliente;
            }
        }

        public IEnumerable<Cliente> All()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Cliente> Find(System.Linq.Expressions.Expression<Func<Cliente, bool>> predicate)
        {
            throw new NotImplementedException();
        }
    }
}
