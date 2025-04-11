using Hattmakarens_system.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hattmakarens_system.ModelsNy
{
    internal class OrderRad
    {
        [Key]
        public int BeställningsRadId { get; set; }

        public int OrderId { get; set; }
        public Order Order { get; set; }

        public int HattId { get; set; }
        public Hatt Hatt { get; set; }

        public string? AnsvarigAnvandare { get; set; }
        public bool? Tillverkad { get; set; }
    }
    public enum HattEnum
    {
        Lager,
        Special
    }
}
