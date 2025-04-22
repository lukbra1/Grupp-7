using Hattmakarens_system.Database;
using Hattmakarens_system.ModelsNy;
using Hattmakarens_system.Presentationslager;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hattmakarens_system.Controllers
{
    internal class StatistikController
    {
        private readonly AppDbContext _context;

        public StatistikController(AppDbContext context)
        {
            this._context = context;
        }

        public List<Modell> HämtaAllaModeller()
        {
            return _context.Modeller.ToList();
        }

        public List<SpecialOrderrad> HämtaAllaSpecialhattar()
        {
            return _context.SpecialOrderrader.ToList();
        }

        public decimal HämtaSumma(int hattmodell, DateTime startDatum, DateTime slutDatum)
        {
            DateTime slutDatumJusterad = slutDatum.Date.AddDays(1).AddTicks(-1);

            decimal resultat = _context.Orderrader
                .OfType<LagerOrderrad>()
                .Where(b => b.ModellId == hattmodell &&
                            b.Order.Skapad >= startDatum.Date &&
                            b.Order.Skapad <= slutDatumJusterad)
                .Sum(b => b.pris ?? 0);



            return resultat;
        }

        public int HämtaAntal(int hattmodell, DateTime startDatum, DateTime slutDatum)
        {
            DateTime slutDatumJusterad = slutDatum.Date.AddDays(1).AddTicks(-1);

            int resultat = _context.Orderrader
                .OfType<LagerOrderrad>()
                .Where(b => b.ModellId == hattmodell &&
                            b.Order.Skapad >= startDatum.Date &&
                            b.Order.Skapad <= slutDatumJusterad)
                .Count();

            return resultat;
        }

        public int HämtaAntalSpecialhatt(DateTime startDatum, DateTime slutDatum)
        {
            DateTime slutDatumJusterad = slutDatum.Date.AddDays(1).AddTicks(-1);

            int resultat = _context.Orderrader
                .OfType<SpecialOrderrad>()
                .Where(b => b.Order.Skapad >= startDatum.Date &&
                            b.Order.Skapad <= slutDatumJusterad)
                .Count();

            return resultat;
        }

        public decimal HämtaSummaSpecialhatt(DateTime startDatum, DateTime slutDatum)
        {
            DateTime slutDatumJusterad = slutDatum.Date.AddDays(1).AddTicks(-1);

            decimal resultat = _context.Orderrader
                .OfType<SpecialOrderrad>()
                .Where(b => b.Order.Skapad >= startDatum.Date &&
                            b.Order.Skapad <= slutDatumJusterad)
                .Sum(b => b.pris ?? 0);
            return resultat;
        }


    }
}
