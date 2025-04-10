using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace Hattmakarens_system.Models
{
    public class Material
    {
        [Key]
        public int MaterialId { get; set; }
        public string Namn { get; set; }
        public string Beskrivning { get; set; }

        public ICollection<HattModellMaterial> HattModeller { get; set; }
        public ICollection<OrderMaterialStatus> OrderStatus { get; set; }
    }
}
