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
        [ForeignKey(nameof(OrderRadId))]
        public int OrderRadId { get; set; }

        [ForeignKey(nameof(UserId))]
        public int UserId { get; set; }
        public User Ansvarig {  get; set; }
        public DateTime Startdatum { get; set; }
        public string Status { get; set; }
    }
}
