using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Hattmakarens_system.Models
{
    public class SpecialHattDetaljer
    {
        [Key]
        public int SpecialHattId {  get; set; }
        public int OrderRadId { get; set; }
        public OrderRad OrderRad { get; set; }

        public string Farg {  get; set; }
        public string Tyg { get; set; }
        public string Text { get; set; }
        public string Dekoration { get; set; }
        public string Storlek { get; set; }
        public string Modell { get; set; }
        public string Fjader { get; set; }
        public string ExtraMaterial { get; set; }
        public string Kommentar { get; set; }
    }
}
