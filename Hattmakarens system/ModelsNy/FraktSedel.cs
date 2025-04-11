using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hattmakarens_system.ModelsNy
{
    internal class FraktSedel
    {
        [Key]
        public int FraktSedelId { get; set; }
        public int ExportKod { get; set; }
        public int Vikt { get; set; }
        public decimal Värde { get; set; }
        public double Moms { get; set; }
        public decimal PrisInkMoms { get; set; }
        public DateTime SkapatDatum { get; set; }
        public int OrderID { get; set; }
        public Order Order { get; set; }
    }
}
