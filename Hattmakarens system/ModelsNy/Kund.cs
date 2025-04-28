using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hattmakarens_system.ModelsNy;
using Microsoft.EntityFrameworkCore;

namespace Hattmakarens_system.ModelsNy
{
    public class Kund
    {
        [Key]
        
        public int KundId { get; set; }
        [MaxLength(50)]
        public string Fornamn { get; set; }
        [MaxLength(50)]
        public string Efternamn { get; set; }
        [MaxLength(50)]
        public string TelefonNr { get; set; }
        [MaxLength(200)]
        public string Epost { get; set; }
        [MaxLength(100)]
        public string Adress { get; set; }
        public bool Aktiv { get; set; }
    }
}
