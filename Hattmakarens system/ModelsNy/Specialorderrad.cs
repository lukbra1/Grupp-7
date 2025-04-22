using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hattmakarens_system.ModelsNy
{
    public class SpecialOrderrad : OrderRad
    {
        public string? Kommentar { get; set; }
        public string? Referensbild { get; set; }
    
    }
}
