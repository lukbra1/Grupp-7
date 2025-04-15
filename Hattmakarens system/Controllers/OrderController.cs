using Hattmakarens_system.Database;
using Hattmakarens_system.ModelsNy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Hattmakarens_system.Database;

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
            List<OrderRad> OrderRader = _context.Orderrader.Where(or => or.OrderId == Order.OrderId).ToList();
            return OrderRader;
        }

        public List<Modell> HämtaAllaModeller()
        {
            return _context.Modeller.ToList();
        }

        public LagerOrderrad LäggTillLagerOrderrad(int orderId, int modellId)
        {
            var orderRad = new LagerOrderrad
            {
                OrderId = orderId,
                ModellId = modellId,
                StatusOrderrad = StatusOrderradEnum.EjPaborjad,
                Tillverkad = false,
                UserId = null
            };

            _context.Orderrader.Add(orderRad);
            _context.SaveChanges();

            return orderRad;
        }

    }
}
