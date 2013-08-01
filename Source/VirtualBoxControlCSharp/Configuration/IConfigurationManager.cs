using System.Xml;

namespace VirtualBoxControlCSharp.Configuration
{
    public interface IConfigurationManager
    {
        IConfigurationStorage Configuration { get; set; }
        void LoadConfiguration(XmlDocument configurationFile);
    }
}
