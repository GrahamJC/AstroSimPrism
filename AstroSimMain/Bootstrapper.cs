using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

using Microsoft.Practices.Unity;

using Prism.Unity;
using Prism.Modularity;

using ModuleA;

namespace AstroSimMain
{
    public class Bootstrapper : UnityBootstrapper
    {
        protected override DependencyObject CreateShell()
        {
            return Container.Resolve<Shell>();
        }

        protected override void InitializeShell()
        {
            base.InitializeShell();
            App.Current.MainWindow = (Window)Shell;
            App.Current.MainWindow.Show();
        }

        protected override void ConfigureModuleCatalog()
        {
            base.ConfigureModuleCatalog();
            Type moduleAType = typeof(ModuleAModule);
            ModuleCatalog.AddModule(new ModuleInfo()
                {
                    ModuleName = moduleAType.Name,
                    ModuleType = moduleAType.AssemblyQualifiedName,
                    InitializationMode = InitializationMode.WhenAvailable
                }
            );
        }
    }
}
