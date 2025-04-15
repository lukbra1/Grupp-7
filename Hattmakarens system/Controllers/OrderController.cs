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
            List<OrderRad> OrderRader = _context.Orderrader.Where(or => or.OrderId == Order.OrderId).ToList();
            return OrderRader;
        }

        public List<Modell> HämtaAllaModeller()
        {
            return _context.Modeller.ToList();
        }

        public LagerOrderrad LäggTillLagerOrderrad(Order order, int modellId)
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
                UserId = null
            };


            _context.Orderrader.Add(orderRad);
            order.TotalPris += modell.Pris;
            _context.SaveChanges();

            return orderRad;
        }

        public void UppdateraOrder(Order order)
        {
            _context.Ordrar.Update(order);
            _context.SaveChanges();
        }

        public decimal BeräknaTotalprisMedEventuellExpress(Order order)
        {
            var orderrader = _context.Orderrader
                .Include(o => (o as LagerOrderrad).Modell)
                .Where(o => o.OrderId == order.OrderId)
                .ToList();

            decimal total = 0;

            foreach (var rad in orderrader)
            {
                if (rad is LagerOrderrad lager)
                {
                    total += lager.Modell?.Pris ?? 0;
                }
                else if (rad is SpecialOrderrad)
                {
                    total += 500; // exempelpris för specialhatt
                }
            }

            if (order.Express)
            {
                total *= 1.2m; // lägg på 20 %
            }

            return total;
        }

    }
}
