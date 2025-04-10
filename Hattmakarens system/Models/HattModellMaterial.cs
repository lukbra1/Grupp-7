using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace Hattmakarens_system.Models
{
    public class HattModellMaterial
    {
        [Key]
        public int HattModellId { get; set; }
        public Hattmodell Hattmodell { get; set; }
        public int MaterialId { get; set; }
        public Material Material { get; set; }
        public decimal Mangd {  get; set; }
    }
}
