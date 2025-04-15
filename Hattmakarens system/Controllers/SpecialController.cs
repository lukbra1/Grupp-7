using Hattmakarens_system.Database;
using Hattmakarens_system.ModelsNy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hattmakarens_system.Controllers
{
    public class SpecialController
    {
        private readonly AppDbContext _context;

        public SpecialController(AppDbContext context)
        {
            this._context = context;
        }

        public SpecialOrderrad NySpecialOrderrad(string kommentar, string referensbild, StorlekEnum storlek)
        {
            SpecialOrderrad specialOrderrad = new SpecialOrderrad
            {
                Kommentar = kommentar,
                Referensbild = referensbild,
                Tillverkad = false,
                StatusOrderrad = StatusOrderradEnum.EjPaborjad,
                TypEnum = TypEnum.Special,
                Storlek = storlek
            };

            return specialOrderrad;
        }

        public void SparaSpecialOrderrad(SpecialOrderrad orderrad)
        {
            _context.SpecialOrderrader.Add(orderrad);
            _context.SaveChanges();
        }
    }
}
