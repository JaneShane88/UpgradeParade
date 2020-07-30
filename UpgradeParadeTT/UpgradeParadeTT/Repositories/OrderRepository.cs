using System;
using System.Collections.Generic;
using UpgradeParadeTT.Interfaces;
using UpgradeParadeTT.Models;

namespace UpgradeParadeTT.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly StoreContext _context;

        public OrderRepository(StoreContext context)
        {
            _context = context;
        }

        public List<Order> GetList()
        {
            return new List<Order>();
        }

        public Order GetById(int id)
        {
            return new Order();
        }

        public void Add(Order order)
        {
            order.Date = DateTime.UtcNow;
            _context.Orders.Add(order);
            _context.SaveChanges();
        }
    }
}
