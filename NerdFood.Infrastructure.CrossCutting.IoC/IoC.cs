using CommonServiceLocator.NinjectAdapter.Unofficial;
using Microsoft.Practices.ServiceLocation;
using Ninject;


namespace NerdFood.Infra.CrossCutting.IoC
{
    public class IoC
    {
        public IoC()
        {
            ServiceLocator.SetLocatorProvider(() => new NinjectServiceLocator(GetNinjectModules()));
        }

        public IKernel Kernel { get; private set; }

        public StandardKernel GetNinjectModules()
        {
            return new StandardKernel(
                new DomainServicesNinjectModule(),
                new DataNinjectModule(),
                new ApplicationNinjectModule());
        }        
    }
}
