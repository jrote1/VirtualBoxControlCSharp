using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject.Modules;
using VirtualBoxControlCSharp.Configuration;

namespace VirtualBoxControlCSharp.DI
{
    public class DependencyMappings : NinjectModule
    {
        public override void Load()
        {
            Bind<IConfigurationManager>().To<ConfigurationManager>().InSingletonScope();
            Bind<IConfigurationStorage>().To<ConfigurationStorage>().InSingletonScope();
        }
    }
}
