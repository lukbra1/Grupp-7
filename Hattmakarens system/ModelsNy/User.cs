using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hattmakarens_system.ModelsNy
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        public string Namn { get; set; }
        public string Epost { get; set; }
        public string Losenord { get; set; }
        public bool Behorighet { get; set; }
    }
}
