using NerdFood.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NerdFood.Domain.Entities;

namespace NerdFood.Application.Interfaces
{
    public interface IApplicationUserAppService : IDisposable
    {
        void Incluir(ApplicationUser AppUser);

        IEnumerable<ApplicationUser> ObterTodos();

        ApplicationUser ObterPorID(string id);

        void Editar(ApplicationUser AppUser);

        void Excluir(ApplicationUser AppUser);
    }
}
