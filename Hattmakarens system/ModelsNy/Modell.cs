using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hattmakarens_system.ModelsNy
{
    public class Modell
    {
        [Key]
        public int ModellId { get; set; }
        public string Namn { get; set; }
        public string Beskrivning { get; set; }
        public bool Tillganglig { get; set; }
    }
}
