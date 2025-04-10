using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hattmakarens_system.Models
{
    
    public class Order
    {
        [Key]
        public int OrderId { get; set; }
        [Required]
        
        public DateTime Datum { get; set; }
        public StatusEnum Status { get; set; }
        public bool Express { get; set; }
        public int TotalPris { get; set; }


        [ForeignKey(nameof(KundId))]
        public int KundId { get; set; }
        
        [ForeignKey(nameof(FraktId))]
        public int FraktId { get; set; }

    }
    public enum StatusEnum
    {
        EjPaborjad,
        Paborjad,
        Fardig
    }
}
