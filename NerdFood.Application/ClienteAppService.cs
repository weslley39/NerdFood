using NerdFood.Application.Interfaces;
using NerdFood.Domain;
using NerdFood.Domain.Entities;
using NerdFood.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NerdFood.Application
{
    public class ClienteAppService : BaseAppService, IClienteAppService
    {
        private readonly IClienteService _clienteService;

        public ClienteAppService(IClienteService ClienteService)
        {
            this._clienteService = ClienteService;
        }

        public void Incluir(Cliente cliente)
        {
            BeginTran();
            _clienteService.Incluir(cliente);
            Commit();
        }

        public IEnumerable<Cliente> ObterTodos()
        {
            return _clienteService.ObterTodos();
        }

        public Cliente ObterPorID(int id)
        {
            return _clienteService.ObterPorID(id);
        }

        public void Editar(Cliente cliente)
        {
            throw new NotImplementedException();
        }

        public void Excluir(Cliente cliente)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
