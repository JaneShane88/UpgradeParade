using Microsoft.AspNetCore.Mvc;
using UpgradeParadeTT.Interfaces;

namespace UpgradeParadeTT.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository _productRepository;
        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public IActionResult ProductList()
        {
            var products = _productRepository.GetList();
            return View(products);
        }
    }
}
