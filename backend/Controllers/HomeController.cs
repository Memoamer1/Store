using System.Diagnostics;
using backend.Models;
using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index() => View();
        public IActionResult Checkout() => View();
        public IActionResult Contact() => View();
        public IActionResult Dashboard() => View();
        public IActionResult Kids() => View();
        public IActionResult Login() => View();
        public IActionResult Men() => View();
        public IActionResult Posts() => View();
        public IActionResult ProductDetails() => View("product-details");
        public IActionResult Settings() => View();
        public IActionResult ShopCart() => View("shop-cart");
        public IActionResult Shop() => View();
        public IActionResult Signup() => View();
        public IActionResult Statistics() => View();
        public IActionResult Users() => View();
        public IActionResult Women() => View();
        public IActionResult Index1() => View("index1");

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
