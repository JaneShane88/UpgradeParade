using System.Collections.Generic;
using System.Linq;
using UpgradeParadeTT.Interfaces;
using UpgradeParadeTT.Models;

namespace UpgradeParadeTT.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly StoreContext _context;

        public ProductRepository(StoreContext context)
        {
            _context = context;
        }

        public List<Product> GetList()
        {
            var products = _context.Products.ToList();
            return products;
        }

        public Product GetById(int id)
        {
            var product = _context.Products.FirstOrDefault(p => p.Id == id);
            return product;
        }

        public void Add(Product product)
        {
        }
    }
}
