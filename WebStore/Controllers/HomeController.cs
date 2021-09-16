using Microsoft.AspNetCore.Mvc;

namespace WebStore.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index() // http://locaalhost:5000/Home/Index
        {
            return Content("Hello from first controller!");
        }

        public IActionResult SecondAction(int id)
        {
            return Content($"Second action with parameter {id}");
        }
    }
}
