using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Stripe;

namespace UpgradeParadeTT.Controllers
{
    public class PaymentController : Controller
    {
        [HttpGet]
        public IActionResult Checkout(Models.Product product)
        {
            product.Price *= 100;
            return View(product);
        }
        [HttpPost]
        public IActionResult Checkout(string stripeEmail, string stripeToken)
        {
            var customers = new CustomerService();
            var charges = new ChargeService();

            var customer = customers.Create(new CustomerCreateOptions
            {
                Email = stripeEmail,
                Source = stripeToken
            });

            var charge = charges.Create(new ChargeCreateOptions
            {
                Amount = 500,
                Description = "Description",
                Currency = "usd",
                Customer = customer.Id,
                ReceiptEmail = stripeEmail,
                Metadata = new Dictionary<string, string>()
                {
                    { "OrderId","111" },
                    { "Postcode", "LEE111" }
                }
            });

            if (charge.Status == "succeeded")
            {
                string BalanceTransactionId = charge.BalanceTransactionId;
                return RedirectToAction("ProductList", "Product");
            }
            return View();
        }
    }
}
