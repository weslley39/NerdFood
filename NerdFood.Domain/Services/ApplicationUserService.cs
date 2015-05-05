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
    public class ApplicationUserService : IApplicationUserService
    {
        private readonly IApplicationUserReadOnlyRepository _applicationUserRepository;

        public ApplicationUserService(IApplicationUserReadOnlyRepository ApplicationUserRepository)
        {
            _applicationUserRepository = ApplicationUserRepository;
        }

        public void Incluir(ApplicationUser AppUser)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ApplicationUser> ObterTodos()
        {
            throw new NotImplementedException();
        }

        public ApplicationUser ObterPorID(string id)
        {
            return _applicationUserRepository.GetById(id);
        }

        public void Editar(ApplicationUser AppUser)
        {
            throw new NotImplementedException();
        }

        public void Excluir(ApplicationUser AppUser)
        {
            throw new NotImplementedException();
        }
    }
}
