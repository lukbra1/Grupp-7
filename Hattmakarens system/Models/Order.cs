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


        public int KundId { get; set; }
        public Kund Kund { get; set; }
        
        public int FraktId { get; set; }
        public Frakt Frakt { get; set; }

    }
    public enum StatusEnum
    {
        EjPaborjad,
        Paborjad,
        Fardig
    }
}
