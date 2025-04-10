using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Hattmakarens_system.Models
{
    public class OrderMaterialStatus
    {
        [ForeignKey(nameof(OrderId))]
        public int OrderId { get; set; }

        [ForeignKey(nameof(MaterialId))]
        public int MaterialId { get; set; }

        public bool Bestallt { get; set; }
    }
}
