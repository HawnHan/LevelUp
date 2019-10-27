using Ninject.Modules;

namespace LevelUp
{
    public class BindingsConfiguration : NinjectModule
    {
        public override void Load()
        {
            this.Bind<IModSettingsWindow>().To<ModSettingsWindow>().InSingletonScope();
        }
    }
}