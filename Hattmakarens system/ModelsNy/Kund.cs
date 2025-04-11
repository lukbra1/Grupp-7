using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hattmakarens_system.Models;
using Microsoft.EntityFrameworkCore;

namespace Hattmakarens_system.ModelsNy
{
    public class Kund
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public int KundId { get; set; }
        public string Fornamn { get; set; }
        public string Efternamn { get; set; }
        public string TelefonNr { get; set; }
        public string Adress { get; set; }
        public bool Aktiv { get; set; }
        //public int OrderId { get; set; }
        //public ICollection<Order> Ordrar { get; set; }
    }
}
