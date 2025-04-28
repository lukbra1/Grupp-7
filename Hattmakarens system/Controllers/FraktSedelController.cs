using Hattmakarens_system.Database;
using Hattmakarens_system.ModelsNy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Hattmakarens_system.Controllers
{
    public class FraktSedelController
    {
        private readonly AppDbContext _context;

        public FraktSedelController(AppDbContext context)
        {
            this._context = context;
        }
        public FraktSedel SkapaFraktsedel(Order _order, int vikt, decimal värde, int exportKod, string adress, string avsändare, string mottagre, string beskrivning)
        {
            var order = _context.Ordrar.FirstOrDefault(o => o.OrderId == _order.OrderId);
            if (order == null)
                throw new Exception("Ordern hittades inte.");

            var moms = 25.0;
            var prisInkMoms = värde;

            var fraktsedel = new FraktSedel
            {
                OrderID = order.OrderId,
                Vikt = vikt,
                Värde = värde,
                ExportKod = exportKod,
                Moms = moms,
                PrisInkMoms = prisInkMoms,
                SkapatDatum = DateTime.Now,
                Adress = adress,
                Avsändare = avsändare,
                Mottagare = mottagre,
                Beskrivning = beskrivning
            };

            _context.Fraktsedlar.Add(fraktsedel);
            _context.SaveChanges();

            return fraktsedel;
        }

        public string HämtaMottagarAdress(Order order) 
        {
            var resultat = _context.Ordrar
                .Where(o => o.OrderId == order.OrderId) 
                .Select(o => o.Kund.Adress) 
                .FirstOrDefault();

            return resultat ?? "Ingen adress hittades";
        }

        public string HämtaMottagareNamn(Order order)
        {
            var resultat = _context.Ordrar
                .Where(o => o.OrderId == order.OrderId)
                .Select(o => o.Kund.Fornamn + " " + o.Kund.Efternamn)
                .FirstOrDefault();

            return resultat ?? "Ingen mottagare hittades";
        }


        public FraktSedel HämtaFraktsedelFörOrder(int orderId)
        {
            return _context.Fraktsedlar.FirstOrDefault(f => f.OrderID == orderId);
        }


    }
}
