using Microsoft.AspNetCore.Mvc;

namespace WebStore.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index() => View();
        public IActionResult Error404() => View();
        public IActionResult Cart() => View();
        public IActionResult Checkout() => View();
        public IActionResult Contacts() => View();
        public IActionResult ProductDetails() => View();

        public IActionResult Status(string id)
        {
            switch (id)
            {
                default: return Content($"Status code --- {id}");
                case "404": return View("Error404");
            }
            
            
        }
    }
}
