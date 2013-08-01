using System;

namespace VirtualBoxControlCSharp.Configuration
{
    public class ConfigurationStorage : IConfigurationStorage
    {
        String IConfigurationStorage.VirtualBoxInstallLocation { get; set; }
    }
}
