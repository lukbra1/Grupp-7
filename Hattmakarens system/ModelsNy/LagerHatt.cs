using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hattmakarens_system.ModelsNy
{
    internal class LagerHatt : Hatt
    {
        public string Namn { get; set; }
        public string? Beskrivning { get; set; }
        public string? Färg { get; set; }
    }
}
