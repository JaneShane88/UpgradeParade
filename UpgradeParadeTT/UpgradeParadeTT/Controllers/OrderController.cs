using Microsoft.AspNetCore.Mvc;
using UpgradeParadeTT.Interfaces;
using UpgradeParadeTT.Models;

namespace UpgradeParadeTT.Controllers
{
    public class OrderController : Controller
    {
        private readonly IProductRepository _productRepository;
        private readonly IOrderRepository _orderRepository;

        public OrderController(
            IProductRepository productRepository,
            IOrderRepository orderRepository)
        {
            _productRepository = productRepository;
            _orderRepository = orderRepository;
        }

        [HttpGet]
        public ViewResult Buy(int productId)
        {
            Order order = new Order();
            order.Product = _productRepository.GetById(productId);
            return View(order);
        }

        [HttpPost]
        public ActionResult Buy(Order order)
        {
            _orderRepository.Add(order);
            if (order.PaymentType == PaymentTypes.Card)
            {
                return RedirectToAction("Checkout", "Payment", new { product = order.Product });
            }
            return RedirectToAction("ProductList", "Product");
        }
    }
}
