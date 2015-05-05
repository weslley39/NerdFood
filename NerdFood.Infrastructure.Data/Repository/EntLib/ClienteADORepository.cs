using System;
using System.Collections.Generic;
using NerdFood.Domain.Entities;
using NerdFood.Domain.Interfaces.Repository;

using NerdFood.Domain;
using System.Data;

namespace NerdFood.Data.Repository.EntLib
{
    public class ClienteADORepository : BaseADORepository, IClienteADORepository
    {
        public void Add(Cliente entity)
        {
            throw new NotImplementedException();
        }
            
        public void Update(Cliente entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Cliente entity)
        {
            throw new NotImplementedException();
        }

        public Cliente GetById(long id)
        {
            var query = "SELECT * FROM CLIENTE WHERE CLIENTEID = " + id.ToString();
            var cliente = new Cliente();

            using (IDataReader reader = Connection.ExecuteReader(CommandType.Text, query))
            {
                while(reader.Read())
                {
                    cliente.ClienteId = (int)reader["ClienteId"];
                    cliente.EmpresaId = (int)reader["EmpresaId"];
                    cliente.Nome = reader["Nome"].ToString();
                }
            }

            return cliente;
        }

        public IEnumerable<Cliente> All()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Cliente> AllReadOnly()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Cliente> Find(System.Linq.Expressions.Expression<Func<Cliente, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
