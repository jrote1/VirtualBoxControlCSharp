using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Ninject;

namespace VirtualBoxControlCSharp.Configuration
{
    internal class ConfigurationManager : IConfigurationManager
    {
        [Inject]
        public IConfigurationStorage Configuration { get; set; }


        public void LoadConfiguration(XmlDocument configurationFile)
        {
            throw new NotImplementedException();
        }
    }
}
