using Hattmakarens_system.ModelsNy;
using Hattmakarens_system.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Hattmakarens_system.Controllers
{
    public class FoljesedelController
    {
        private readonly AppDbContext _context;

        public FoljesedelController(AppDbContext context)
        {
            _context = context;
        }

        public Order HämtaOrderMedOrderrader(int orderId)
        {
            return _context.Ordrar
                .Where(o => o.OrderId == orderId)
                .Select(o => new Order
                {
                    OrderId = o.OrderId,
                    Kund = o.Kund,
                    TotalPris = o.TotalPris,
                    Skapad = o.Skapad,
                    OrderRader = o.OrderRader.ToList()
                }).FirstOrDefault();



        }

        public Kund HämtaKundTillOrder(int orderId)
        {
            return _context.Ordrar
                .Include(o => o.Kund)          // Ladda även kundobjektet
                .FirstOrDefault(o => o.OrderId == orderId)
                ?.Kund;                        // Returnera kund (om ordern hittas)
        }

        public List<OrderRad> HämtaOrderraderFörFöljesedel(int orderId)
        {
            return _context.Orderrader
                .Include(or => (or as LagerOrderrad).Modell)
                .Where(or => or.OrderId == orderId)
                .ToList();
        }

    }
}