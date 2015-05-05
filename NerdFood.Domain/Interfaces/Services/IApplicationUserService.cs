using System;
using System.Collections.Generic;
using NerdFood.Domain;
using NerdFood.Domain.Entities;

namespace NerdFood.Domain.Interfaces.Services
{
    public interface IApplicationUserService
    {
        void Incluir(ApplicationUser AppUser);

        IEnumerable<ApplicationUser> ObterTodos();

        ApplicationUser ObterPorID(string id);

        void Editar(ApplicationUser AppUser);

        void Excluir(ApplicationUser AppUser);
    }
}
