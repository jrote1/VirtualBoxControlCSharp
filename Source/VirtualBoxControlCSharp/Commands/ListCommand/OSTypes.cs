using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OperatingSystem = VirtualBoxControlCSharp.Types.OperatingSystem;

namespace VirtualBoxControlCSharp.Commands.ListCommand
{
    public class OSTypes : BaseCommand
    {
        private const string command = "VBoxManage list ostypes";

        public List<OperatingSystem> Execute()
        {
            ExecuteCommand(command);

            return new List<OperatingSystem>();
        }
    }
}
