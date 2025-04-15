using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hattmakarens_system.ModelsNy
{
    public class MaterialOrderrad
    {
        public int MaterialId { get; set; }
        public Material Material { get; set; }

        public int OrderRadId { get; set; }
        public OrderRad OrderRad { get; set; }

        public bool Bestallt { get; set; } // Ny egenskap för att markera om materialet är beställt
    }

}
