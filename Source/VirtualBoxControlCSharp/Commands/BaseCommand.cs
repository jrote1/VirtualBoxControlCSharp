using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;
using VirtualBoxControlCSharp.Configuration;

namespace VirtualBoxControlCSharp.Commands
{
    public class BaseCommand
    {
        [Inject]
        public IConfigurationManager ConfigurationManager { get; set; }

        public virtual string ExecuteCommand(string command)
        {
            var proc = new Process
            {
                StartInfo =
                {
                    FileName = "cmd.exe",
                    Arguments = ConfigurationManager.Configuration.VirtualBoxInstallLocation + "/" + command,
                    UseShellExecute = false,
                    RedirectStandardOutput = true
                }
            };
            proc.Start();
            return proc.StandardOutput.ReadToEnd();
        }
    }
}
