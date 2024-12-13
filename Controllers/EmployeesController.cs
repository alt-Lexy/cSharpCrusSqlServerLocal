using EmployeeAdminPortal.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeAdminPortal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly ApplicationDbContextcs dbContext;
        public EmployeesController(ApplicationDbContextcs dbContextcs)
        {
            this.dbContext = dbContextcs;
            
        }
        [HttpGet]
        public IActionResult GetAllEmployees()
        {
            var allEmployees = dbContext.Employee.ToList();

            return Ok(allEmployees);
        }
    }
}
