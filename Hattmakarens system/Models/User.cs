using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace Hattmakarens_system.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        public string Namn { get; set; }
        public string Epost { get; set; }
        public string LosenordHash { get; set; }
        public bool Behorighet { get; set; } // om det är true = admin
    }
}
