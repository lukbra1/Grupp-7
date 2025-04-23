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

        public List<Order> HämtaAllaOrdrar()
        {
            return _context.Ordrar.ToList();
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

        public LagerOrderrad LäggTillLagerOrderrad(Order order, LagerOrderrad orderrad)
        {
            _context.Orderrader.Add(orderrad);
            order.TotalPris += orderrad.Modell.Pris;
            _context.SaveChanges();
            return orderrad;
        }

        public void UppdateraOrder(Order order)
        {
            _context.Ordrar.Update(order);
            _context.SaveChanges();
        }

        public void TilldelaOrderRad(OrderRad orderrad, int userId, DateTime datum)
        {
            orderrad.TilldeladOrder = true;
            orderrad.UserId = userId;
            orderrad.TilldelningsDatum = datum;
            _context.Orderrader.Update(orderrad);
            _context.SaveChanges();
        }


        public List<OrderRad> HämtaAllaOrderRaderTilldelade()
        {
            return _context.Orderrader
                .Include(or => or.Order)
                .ThenInclude(o => o.Kund)
                .Where(or => or.TilldeladOrder && or.TilldelningsDatum != null)
                .ToList();
        }

        public void UppdateraOrderRad(OrderRad orderrad)
        {
            _context.Orderrader.Update(orderrad);
            _context.SaveChanges();
        }

        public void TaBortTomOrder(Order Ordern)
        {
            _context.Ordrar.Remove(Ordern);
            _context.SaveChanges();
        }


    }
}
