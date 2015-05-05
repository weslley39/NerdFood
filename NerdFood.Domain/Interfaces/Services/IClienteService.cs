using System;
using System.Collections.Generic;
using NerdFood.Domain;
using NerdFood.Domain.Entities;

namespace NerdFood.Domain.Interfaces.Services
{
    public interface IClienteService
    {
        void Incluir(Cliente cliente);

        IEnumerable<Cliente> ObterTodos();

        Cliente ObterPorID(int id);

        void Editar(Cliente cliente);

        void Excluir(Cliente cliente);
    }
}
