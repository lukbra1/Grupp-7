using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hattmakarens_system.ModelsNy
{
    public class LagerOrderrad : OrderRad
    {
        public int ModellId { get; set; }
        public Modell Modell { get; set; }
    }
}
