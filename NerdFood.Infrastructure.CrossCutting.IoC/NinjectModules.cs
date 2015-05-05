using Ninject.Modules;
using Ninject.Web.Mvc.FilterBindingSyntax;

using NerdFood.Domain.Interfaces.Services;
using NerdFood.Domain.Services;
using NerdFood.Domain.Interfaces.Infra;
using NerdFood.Domain.Interfaces.Repository;

using NerdFood.Infra.Data.Config;
using NerdFood.Infra.Data.Interfaces;
using NerdFood.Infra.Data.Repository.EF;
using NerdFood.Infra.Data.DbContexts;
using NerdFood.Application.Interfaces;
using NerdFood.Application;
using NerdFood.Data.Config;
using NerdFood.Data.Repository.Dapper;
using NerdFood.Data.Repository.EntLib;
using NerdFood.Infra.CrossCutting.Identity;

using System.Web.Mvc;
using NerdFood.Infra.CrossCutting.MvcFilters;

namespace NerdFood.Infra.CrossCutting.IoC
{
    public class DomainServicesNinjectModule : NinjectModule
    {
        public override void Load()
        {
            Bind(typeof(IService<>)).To(typeof(BaseService<>));
            Bind<IClienteService>().To<ClienteService>();
            Bind<IApplicationUserService>().To<ApplicationUserService>();
        }
    }

    public class ApplicationNinjectModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IClienteAppService>().To<ClienteAppService>();
            Bind<IApplicationUserAppService>().To<ApplicationUserAppService>();

            // Filters
            this.BindFilter<UserDataCacheFilter>(FilterScope.Controller, 0).WhenControllerHas<UserDataCacheAttribute>();
        }
    }

    public class DataNinjectModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IDbContext>().To<NerdFoodContext>();
            Bind<IUnitOfWork>().To<UnitOfWork>();
            Bind(typeof(IRepository<>)).To(typeof(BaseRepository<>));
            Bind<IContextManager>().To<ContextManager>();
            Bind<IClienteReadOnlyRepository>().To<ClienteReadOnlyRepository>();
            Bind<IClienteADORepository>().To<ClienteADORepository>();
            Bind<IAppUser>().To<AppIdentityUser>();
            Bind<IApplicationUserReadOnlyRepository>().To<ApplicationUserReadOnlyRepository>();
        }
    }   
}
