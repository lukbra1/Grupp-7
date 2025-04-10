using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Hattmakarens_system.Models
{
    public class Tillverkningsschema
    {
        [Key]
        public int SchemaId { get; set; }
        public int OrderRadId { get; set; }
        public OrderRad OrderRad { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }
        public DateTime Startdatum { get; set; }
        public string Status { get; set; }
    }
}
