using DepartmentService.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DepartmentService.Controllers
{
    [Route("api/controller")]
    [ApiController]
    public class DepartmentController : Controller
    {
        DepartmentContext _context;
        public DepartmentController(DepartmentContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Department>>> GetDepatments()
        {
            return await _context.Departments.ToListAsync();
        }
    }
}
