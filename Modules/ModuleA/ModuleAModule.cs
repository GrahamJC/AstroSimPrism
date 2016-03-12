using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Practices.Unity;

using Prism.Modularity;
using Prism.Unity;
using Prism.Regions;

namespace ModuleA
{
    public class ModuleAModule : IModule
    {
        private IUnityContainer container;
        private IRegionManager regionManager;

        public ModuleAModule( IUnityContainer container, IRegionManager regionManager )
        {
            this.container = container;
            this.regionManager = regionManager;
        }

        public void Initialize()
        {
            regionManager.RegisterViewWithRegion("ToolbarRegion", typeof(ToolbarView));
            regionManager.RegisterViewWithRegion("ContentRegion", typeof(ContentView));
        }
    }
}
