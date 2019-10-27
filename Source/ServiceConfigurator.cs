using Ninject;
using Ninject.Modules;

namespace LevelUp
{
    public class ServiceConfigurator
    {
        public static void ConfigureServices()
        {
            INinjectSettings serviceSettings = new ServiceSettings();
            INinjectModule bindingsConfiguration = new BindingsConfiguration();
            IKernel kernel = new StandardKernel(serviceSettings, bindingsConfiguration);
        }
    }
}