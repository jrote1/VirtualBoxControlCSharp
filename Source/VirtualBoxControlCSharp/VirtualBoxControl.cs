using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Microsoft.Practices.ServiceLocation;
using VirtualBoxControlCSharp.Configuration;
using VirtualBoxControlCSharp.DI;

namespace VirtualBoxControlCSharp
{
    public class VirtualBoxControl
    {
        public IConfigurationManager ConfigurationManager { get; private set; }

        /// <summary>
        /// Initialize VirtualBoxControl With New Configuration
        /// </summary>
        /// <param name="virtualBoxPath">VirtualBox Directory</param>
        public VirtualBoxControl(String virtualBoxPath)
        {
            DependencyInjection.Initialize();
            ConfigurationManager = ServiceLocator.Current.GetInstance<IConfigurationManager>();
            ConfigurationManager.Configuration.VirtualBoxInstallLocation = virtualBoxPath;
        }

        /// <summary>
        /// Initialize VirtualBoxControl From Previous Configuration
        /// </summary>
        /// <param name="configurationFile">Configuration file created by Configuration Manager Export</param>
        public VirtualBoxControl(XmlDocument configurationFile)
        {
            DependencyInjection.Initialize();
            ConfigurationManager = ServiceLocator.Current.GetInstance<IConfigurationManager>();
            ConfigurationManager.LoadConfiguration(configurationFile);
        }


    }
}
