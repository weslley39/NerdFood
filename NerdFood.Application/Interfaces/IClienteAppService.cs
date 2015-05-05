using NerdFood.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NerdFood.Domain.Entities;

namespace NerdFood.Application.Interfaces
{
    public interface IClienteAppService : IDisposable
    {
        void Incluir(Cliente cliente);

        IEnumerable<Cliente> ObterTodos();

        Cliente ObterPorID(int id);

        void Editar(Cliente cliente);

        void Excluir(Cliente cliente);
    }
}
