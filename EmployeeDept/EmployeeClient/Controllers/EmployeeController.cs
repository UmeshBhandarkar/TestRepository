using EmployeeClient.Models;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeClient.Controllers
{
    public class EmployeeController : Controller
    {
        public EmployeeService _employeeService;

        public EmployeeController(EmployeeService employeeService)
        {
            _employeeService = employeeService;
        }
        public async Task<IActionResult> Index()
        {
            var emp = await _employeeService.GetEmployeesAsync();
            return View(emp);
        }
    }
}
