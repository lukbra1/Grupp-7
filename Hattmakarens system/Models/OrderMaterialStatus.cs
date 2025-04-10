using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hattmakarens_system.Models
{
    public class OrderMaterialStatus
    {
        public int OrderId { get; set; }
        public Order Order { get; set; }

        public int MaterialId { get; set; }
        public Material Material { get; set; }

        public bool Bestallt { get; set; }
    }
}
