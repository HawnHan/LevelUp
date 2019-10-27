using Ninject;
using Ninject.Modules;

namespace LevelUp
{
    public class Provider
    {
        private static Provider provider;
        private IKernel kernel;

        public Provider()
        {
            INinjectSettings serviceSettings = new ServiceSettings();
            INinjectModule bindingsConfiguration = new BindingsConfiguration();
            this.kernel = new StandardKernel(serviceSettings, bindingsConfiguration);
        }

        public static T Get<T>()
        {
            if (provider == null)
            {
                provider = new Provider();
            }

            return provider.kernel.Get<T>();
        }
    }
}