using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.ComponentModel.DataAnnotations;

namespace Hattmakarens_system.Models
{
    public class Kund
    {
        [Key]
        public int KundId { get; set; }
        [Required]
        [MaxLength(50)]
        public string ForNamn { get; set; }
        [MaxLength(50)]
        [Required]
        public string EfterNamn { get; set; }
        [Phone]
        [MaxLength(50)]
        public string Telefon { get; set; }
        [EmailAddress]
        [MaxLength(200)]
        public string Epost { get; set; }
        [Required]
        [MaxLength(100)]
        public string Adress { get; set; }
        public bool Aktiv { get; set; }


    }

}
