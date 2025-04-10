using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace Hattmakarens_system.Models
{
    public class Hattmodell
    {
        [Key]
        public int HattModellId { get; set; }
        public string Namn { get; set; }
        public decimal Pris { get; set; }
        public string Beskrivning { get; set; }
        public bool Tillgangliga { get; set; }

        public ICollection<HattModellMaterial> Material { get; set; }
        public ICollection<OrderItem> Orderrader { get; set; }
    }
}
