using System;

namespace VirtualBoxControlCSharp.Configuration
{
    public interface IConfigurationStorage
    {
        String VirtualBoxInstallLocation { get; set; }
    }
}
