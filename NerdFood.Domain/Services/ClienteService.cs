using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NerdFood.Domain.Entities;
using NerdFood.Domain.Interfaces.Services;
using NerdFood.Domain.Interfaces.Repository;

namespace NerdFood.Domain.Services
{
    public class ClienteService : IClienteService
    {
        private readonly IRepository<Cliente> _repository;
        private readonly IClienteADORepository _clienteADORepository;
        private readonly IClienteReadOnlyRepository _clienteReadOnlyRepository;

        public ClienteService
            (
                IRepository<Cliente> clienteRepository, 
                IClienteReadOnlyRepository clienteReadOnlyRepository,
                IClienteADORepository clienteADORepository
            )
        {
            _repository = clienteRepository;
            _clienteReadOnlyRepository = clienteReadOnlyRepository;
            _clienteADORepository = clienteADORepository;
        }


        public void Incluir(Cliente cliente)
        {
            _repository.Add(cliente);
        }

        public IEnumerable<Cliente> ObterTodos()
        {
            return _repository.All();
        }

        public Cliente ObterPorID(int id)
        {
            var R = _repository.GetById(id);
            var RO = _clienteReadOnlyRepository.GetById(id);
            var RADO = _clienteADORepository.GetById(id);

            return R;
        }

        public void Editar(Cliente cliente)
        {
            throw new NotImplementedException();
        }

        public void Excluir(Cliente cliente)
        {
            throw new NotImplementedException();
        }
    }
}
