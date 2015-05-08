using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.ObjectDefines
{
    public class Realm
    {
        public uint Id { get; set; }
        public string Name { get; set; }
        public string IP { get; set; }
        public uint Port { get; set; }
    }
}