using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hattmakarens_system.ModelsNy
{
    internal class Material_Hatt
    {
        public int HattId { get; set; }
        public Hatt Hatt { get; set; }
        public int MaterialId { get; set; }
        public Material Material { get; set; }
    }
}
