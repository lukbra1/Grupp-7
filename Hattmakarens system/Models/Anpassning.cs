using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Hattmakarens_system.Models
{
    public class Anpassning
    {
        [Key]
        public int AnpassningId { get; set; }
        public string Typ { get; set; }
        public string Varde { get; set; }
        public decimal Anpassningkostnad { get; set; }
        public int OrderRadId { get; set; }
        public OrderRad OrderRad { get; set; }

    }
}
