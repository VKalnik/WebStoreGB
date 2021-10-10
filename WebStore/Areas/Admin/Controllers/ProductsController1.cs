using Microsoft.AspNetCore.Mvc;

namespace WebStore.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductsController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
