using Hattmakarens_system.ModelsNy;
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

        public int? UserId { get; set; }
        public User User { get; set; }
        public bool? Tillverkad { get; set; }
        public StatusOrderradEnum StatusOrderrad { get; set; }
        public TypEnum TypEnum { get; set; }
        public StorlekEnum Storlek { get; set; }

        public bool TilldeladOrder { get; set; } 

        public DateTime? TilldelningsDatum { get; set; } //så att order som tilldelats i kalender sparas i databasen

        public decimal? pris {  get; set; }

    }
    public enum TypEnum
    {
        Lager,
        Special
    }
    public enum StatusOrderradEnum
    {
        EjPaborjad,
        Paborjad,
        Färdig,
    }
    public enum StorlekEnum
    {
        XS,
        S,
        M,
        L,
        XL
        

    }
}
