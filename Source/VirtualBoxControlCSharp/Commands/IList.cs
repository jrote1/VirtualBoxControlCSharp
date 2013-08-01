using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualBoxControlCSharp.Commands
{
    public interface IList
    {
        List<OperatingSystem> OSTypes();
    }
}
