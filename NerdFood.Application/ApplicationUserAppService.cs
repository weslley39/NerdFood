using NerdFood.Domain;
using NerdFood.Application.Interfaces;
using NerdFood.Domain.Entities;
using NerdFood.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NerdFood.Application
{
    public class ApplicationUserAppService : BaseAppService, IApplicationUserAppService
    {
        private readonly IApplicationUserService _applicationUserService;

        public ApplicationUserAppService(IApplicationUserService ApplicationUserService)
        {
            this._applicationUserService = ApplicationUserService;
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
            return _applicationUserService.ObterPorID(id);
        }

        public void Editar(ApplicationUser AppUser)
        {
            throw new NotImplementedException();
        }

        public void Excluir(ApplicationUser AppUser)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
