using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hattmakarens_system.Models
{
    public class OrderRad
    {
        [Key]
        public int OrderRadId { get; set; }
        public HattEnum Typ { get; set; }

        public decimal Pris { get; set; }

        //public blabla Status { get; set; }

        public string? ReferensBild { get; set; }

        [ForeignKey(nameof(UserId))]
        public int UserId { get; set; }

        [ForeignKey(nameof(HattModellId))]
        public string HattModellId { get; set; }










    }
    public enum HattEnum
    {
        Lager,
        Special
    }
}
