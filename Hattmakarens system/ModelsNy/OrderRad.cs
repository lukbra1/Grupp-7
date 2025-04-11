using Hattmakarens_system.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hattmakarens_system.ModelsNy
{
    public class OrderRad 
    {
        [Key]
        public int OrderRadId { get; set; }

        public int OrderId { get; set; }
        public Order Order { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }
        public bool? Tillverkad { get; set; }
    }
    public enum HattEnum
    {
        Lager,
        Special
    }
}
