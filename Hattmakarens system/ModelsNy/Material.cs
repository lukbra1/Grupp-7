using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hattmakarens_system.ModelsNy
{
    internal class Material
    {
        public int MaterialId { get; set; }
        public string Namn { get; set; }
        public string Beskrivning { get; set; }
        public ICollection<Material_Hatt> Material_Hattar { get; set; }


    }
}
