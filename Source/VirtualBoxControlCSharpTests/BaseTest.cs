using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtualBoxControlCSharpTests.Properties;

namespace VirtualBoxControlCSharpTests
{
    public class BaseTest
    {
        public String VirtualBoxPath
        {
            get
            {
                return Settings.Default.VirtualBoxPath;
            }
        }
    }
}
