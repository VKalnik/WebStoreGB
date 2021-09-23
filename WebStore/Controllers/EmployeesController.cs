using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebStore.Sevices.Interfaces;

namespace WebStore.Controllers
{
    //[Route("Employrrs/[action]/{id?}")]
    //[Route("Staff/[action]/{id?}")]
    public class EmployeesController : Controller
    {
        private readonly IEmployeesData _EmployeesData;
        private readonly ILogger<EmployeesController> _Logger;

        public EmployeesController(IEmployeesData EmployeesData, ILogger<EmployeesController> Logger)
        {
            _EmployeesData = EmployeesData;
            _Logger = Logger;
        }

        //[Route("~/employees/all")]
        public IActionResult Index() => View(_EmployeesData.GetAll());

        //[Route("~/employees/all/info-{id}")]
        public IActionResult Details(int id)
        {
            var employee = _EmployeesData.GetById(id);
            if (employee is null)
                return NotFound();

            return View(employee);
        }
    }
}
