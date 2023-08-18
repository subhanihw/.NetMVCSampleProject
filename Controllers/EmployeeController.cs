using Microsoft.AspNetCore.Mvc;
using SampleMVCApp.Models;

namespace SampleMVCApp.Controllers
{
    public class EmployeeController : Controller
    {
        private static List<EmployeeViewModel> employees = new List<EmployeeViewModel>();
        public IActionResult Index()
        {
            return View(employees);
        }
        public IActionResult Create()
        {
            var emp = new EmployeeViewModel();
            return View(emp);
        }

        public IActionResult CreateEmployee(EmployeeViewModel employee)
        {
            /*return View("Index");*/
            employees.Add(employee);
            return RedirectToAction(nameof(Index));
        }
    }
}
