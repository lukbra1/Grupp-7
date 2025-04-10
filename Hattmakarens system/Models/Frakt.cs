using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hattmakarens_system.Models
{
    public class Frakt
    {

        [Key]
        public int FraktId { get; set; }
        public int ExportKod { get; set; }
        public int Vikt { get; set; }
        public decimal Värde { get; set; }
        public double Moms { get; set; }
        public decimal PrisInkMoms { get; set; }
        public DateTime SkapatDatum { get; set; }
        [ForeignKey(nameof(OrderID))]
        public int OrderID { get; set; }


    }
}
