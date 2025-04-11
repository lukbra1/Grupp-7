using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hattmakarens_system.ModelsNy
{
    internal class Hatt
    {
        public int HattId { get; set; }
        public decimal? Pris { get; set; }
        public string? Storlek { get; set; }
        public string? ReferensBildPath { get; set; }

        public ICollection<Material_Hatt> Material_Hattar { get; set; }


    }
}
