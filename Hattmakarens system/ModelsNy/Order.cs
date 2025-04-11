using Hattmakarens_system.Models;
using Microsoft.EntityFrameworkCore.SqlServer.Query.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hattmakarens_system.ModelsNy
{
    internal class Order
    {
            [Key]
            public int OrderId { get; set; }

            public DateTime Skapad { get; set; }
            public StatusEnum Status { get; set; }
            public bool Express { get; set; }
            public decimal TotalPris { get; set; }

            public int KundId { get; set; }
            public Kund Kund { get; set; }

            public ICollection<OrderRad> OrderRader { get; set; } = new List<OrderRad>();

            public int? FraktId { get; set; }
            public Frakt? Frakt { get; set; }
        
    }
    public enum StatusEnum
    {
        EjPaborjad,
        Paborjad,
        Fardig
    }

}
