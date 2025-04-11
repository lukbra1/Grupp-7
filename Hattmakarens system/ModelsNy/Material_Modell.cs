using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hattmakarens_system.ModelsNy
{
    public class Material_Modell
    {
        public int ModellId { get; set; }
        public Modell Modell { get; set; }
        public int MaterialId { get; set; }
        public Material Material { get; set; }

    }
}
