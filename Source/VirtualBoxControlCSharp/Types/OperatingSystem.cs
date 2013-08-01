using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualBoxControlCSharp.Types
{
    public class OperatingSystem
    {
        public String ID { get; set; }
        public String Description { get; set; }
        public String FamilyID { get; set; }
        public String FamilyDescription { get; set; }
        public Boolean Is64Bit { get; set; }
    }
}
