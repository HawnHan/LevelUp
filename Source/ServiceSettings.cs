using Ninject;
using Ninject.Activation;
using Ninject.Infrastructure;
using System;

namespace LevelUp
{
    public class ServiceSettings : INinjectSettings
    {
        public ServiceSettings()
        {
            this.ActivationCacheDisabled = false;
            this.AllowNullInjection = false;
            this.CachePruningInterval = TimeSpan.FromSeconds(30);
            this.DefaultScopeCallback = StandardScopeCallbacks.Transient;
            this.InjectAttribute = typeof(InjectAttribute);
            this.InjectNonPublic = false;
            this.LoadExtensions = false;
            this.UseReflectionBasedInjection = false;
        }

        public Type InjectAttribute { get; set; }

        public TimeSpan CachePruningInterval { get; set; }

        public Func<IContext, object> DefaultScopeCallback { get; set; }

        public bool LoadExtensions { get; set; }

        public string[] ExtensionSearchPatterns { get; set; }

        public bool UseReflectionBasedInjection { get; set; }

        public bool InjectNonPublic { get; set; }
        public bool InjectParentPrivateProperties { get; set; }
        public bool ActivationCacheDisabled { get; set; }
        public bool AllowNullInjection { get; set; }

        public T Get<T>(string key, T defaultValue) => default;

        public void Set(string key, object value)
        {
        }
    }
}