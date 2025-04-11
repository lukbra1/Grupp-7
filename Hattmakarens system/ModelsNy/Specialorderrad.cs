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
        
        public string Farg { get; set; }
        public string Tyg { get; set; }
        public string Text { get; set; }
        public string Dekoration { get; set; }
        public string Storlek { get; set; }
        public string Modell { get; set; }
        public string Fjader { get; set; }
        public string ExtraMaterial { get; set; }
        public string Kommentar { get; set; }
    }
}
