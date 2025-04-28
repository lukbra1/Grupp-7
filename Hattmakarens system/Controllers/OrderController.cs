using Hattmakarens_system.Database;
using Hattmakarens_system.ModelsNy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Hattmakarens_system.Database;
using Microsoft.EntityFrameworkCore;

namespace Hattmakarens_system.Controllers
{
    internal class OrderController
    {
        private readonly AppDbContext _context;

        public OrderController(AppDbContext context) 
        {
            this._context = context;
        }

        public Order SkapaNyOrder(int KundId)
        {
            Order Order = new Order
            {
                Skapad = DateTime.Today,
                Status = StatusEnum.EjPaborjad,
                Express = false,
                TotalPris = 0,
                KundId = KundId,
                OrderRader = new List<OrderRad>()
            };
            _context.Ordrar.Add(Order);
            _context.SaveChanges();
            return Order;
        }

        public List<OrderRad> HämtaAllaOrderRader(Order Order)
        {
            List<OrderRad> allaRader = _context.Orderrader
                .Where(or => or.OrderId == Order.OrderId)
                .AsNoTracking()
                .ToList();

            List<LagerOrderrad> lagerRader = allaRader
                .OfType<LagerOrderrad>()
                .ToList();

            foreach (LagerOrderrad rad in lagerRader)
            {
                _context.Entry(rad).Reference(r => r.Modell).Load();
            }

            return allaRader;
        }

        public List<Order> HämtaAllaOrdrar()
        {
            return _context.Ordrar.ToList();
        }

        public List<Order> SorteraOdrar() 
        { 
            return _context.Ordrar.OrderByDescending(o => o.OrderId).ToList();
                
        }

        public List<Modell> HämtaAllaModeller()
        {
            return _context.Modeller.ToList();
        }

        public List<Order> HämtaAllaOrdrarMedKund()
        {
            return _context.Ordrar
                .Include(o => o.Kund)
                .Include(o => o.OrderRader)
                .ToList();
        }
        public LagerOrderrad LäggTillLagerOrderrad(Order order, int modellId, StorlekEnum storlek)
        {
            
            var modell = _context.Modeller.FirstOrDefault(m => m.ModellId == modellId);

            if (order == null || modell == null)
                throw new Exception("Order eller modell hittades inte.");

            var orderRad = new LagerOrderrad
            {
                OrderId = order.OrderId,
                ModellId = modellId,
                StatusOrderrad = StatusOrderradEnum.EjPaborjad,
                Tillverkad = false,
                UserId = null,
                Storlek = storlek
            };

            _context.Orderrader.Add(orderRad);
            order.TotalPris += modell.Pris;
            _context.SaveChanges();

            return orderRad;
        }

        public LagerOrderrad LäggTillLagerOrderrad(Order order, LagerOrderrad orderrad)
        {
            _context.Orderrader.Add(orderrad);
            order.TotalPris += orderrad.Modell.Pris;
            _context.SaveChanges();
            return orderrad;
        }

        public void TilldelaOrderRad(OrderRad orderrad, int userId, DateTime datum)
        {
            _context.ChangeTracker.Clear();
            orderrad.TilldeladOrder = true;
            orderrad.UserId = userId;
            orderrad.TilldelningsDatum = datum;

            orderrad.StatusOrderrad = StatusOrderradEnum.Paborjad;

            _context.Orderrader.Update(orderrad);
            _context.SaveChanges();
        }

        public List<OrderRad> HämtaAllaOrderRaderTilldelade()
        {
            return _context.Orderrader
         .Include(or => or.Order)
             .ThenInclude(o => o.Kund) // <- DETTA gör att Kund också inkluderas
         .Include(or => or.User)
         .Where(or => or.TilldeladOrder && or.TilldelningsDatum != null)
         .ToList();
        }

        public void TaBortTomOrder(Order Ordern)
        {
            _context.Ordrar.Remove(Ordern);
            _context.SaveChanges();
        }

        public decimal HämtaTotalOrderPris(Order ordern)
        {
            var orderId = ordern.OrderId;

            var totalSumma = _context.Orderrader
                .Where(or => or.OrderId == orderId)
                .Sum(or => or.pris ??  0);
             
            return totalSumma;
        }
        public decimal BeräknaOrderPrisInkMoms(Order ordern)
        {
            decimal orderTotalPris = HämtaTotalOrderPris(ordern);
            decimal moms = 1.25m;
            decimal express = ordern.Express ? 1.20m : 1m;

            return orderTotalPris * moms * express;
        }

        public IEnumerable<dynamic> HämtaMatrialFörOrderRader(int orderId)
        {
            var orderRader = _context.Orderrader
                .Where(or => or.OrderId == orderId)
                .Select(or => or.OrderRadId)
                .ToList();

            var materialOrderrader = _context.MaterialOrderrader
                .Where(mor => orderRader.Contains(mor.OrderRadId))
                .Include(mor => mor.Material)
                .ToList();

            var resultat = materialOrderrader
                .GroupBy(mor => new { mor.OrderRadId, mor.MaterialId })
                .Select(grupp => new
                {
                    OrderRadId = grupp.Key.OrderRadId,
                    Material = grupp.First().Material,
                    TotalAntal = grupp.Sum(mor => mor.AntalMaterial),
                    Bestallt = grupp.First().Bestallt
                });

            return resultat;

        }

        public void AvTilldelaOrderRad(OrderRad orderrad)
        {
            _context.ChangeTracker.Clear();

            var tracked = _context.Orderrader
                .FirstOrDefault(r => r.OrderRadId == orderrad.OrderRadId);

            if (tracked == null)
                throw new Exception("Orderrad kunde inte hittas.");

            tracked.TilldeladOrder = false;
            tracked.UserId = null;
            tracked.TilldelningsDatum = null;

            if (tracked.StatusOrderrad == StatusOrderradEnum.Paborjad)
                tracked.StatusOrderrad = StatusOrderradEnum.EjPaborjad;

            _context.SaveChanges();
        }
        public List<Order> HämtaOrdrarMedObeställtMaterial()
        {
            return _context.MaterialOrderrader
                .Include(m => m.Material)
                .Include(m => m.OrderRad)
                    .ThenInclude(or => or.Order)
                        .ThenInclude(o => o.Kund)
                .Where(m => !m.Bestallt && m.OrderRad.Order.Kund != null && m.OrderRad.Order.Kund.Aktiv)
                .Select(m => m.OrderRad.Order)
                .Distinct()
                .ToList();
        }

        public List<Order> HämtaOrdrarMedObeställtMaterialInomDatum(DateTime start, DateTime slut)
        {
            return _context.MaterialOrderrader
                .Include(m => m.Material)
                .Include(m => m.OrderRad)
                    .ThenInclude(or => or.Order)
                        .ThenInclude(o => o.Kund)
                .Where(m => !m.Bestallt
                            && m.OrderRad.Order.Kund != null
                            && m.OrderRad.Order.Kund.Aktiv
                            && m.OrderRad.Order.Skapad >= start
                            && m.OrderRad.Order.Skapad <= slut)
                .Select(m => m.OrderRad.Order)
                .Distinct()
                .ToList();
        }

    }
}
