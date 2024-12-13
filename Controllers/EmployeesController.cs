using EmployeeAdminPortal.Data;
using EmployeeAdminPortal.Models;
using EmployeeAdminPortal.Models.Entities;
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

        [HttpGet]
        [Route("{id:guid}")]
        public IActionResult GetEmployeeById(Guid id) {
            var employee = dbContext.Employee.Find(id);
            if (employee is null) { 
                return NotFound();
            }
            return Ok(employee);
        }

        [HttpPost]
        public IActionResult AddEmployees(AddEmployeeDto addEmployeeDto)
        {
            var employeeEntity = new Employee()
            {
                Name = addEmployeeDto.Name,
                Email = addEmployeeDto.Email,
                Phone = addEmployeeDto.Phone,
                Salary = addEmployeeDto.Salary,
            };

            dbContext.Employee.Add(employeeEntity);
            dbContext.SaveChanges();

            return Ok(employeeEntity);
        }

        [HttpPut]
        [Route("{id:guid}")]
        public IActionResult updateEmployee(Guid id, UpdateEmployeeDto updateEmployeeDto)
        {
            var employeeId = dbContext.Employee.Find(id);
            if (employeeId is null)
            { 
                return NotFound();
            }

            employeeId.Name = updateEmployeeDto.Name;
            employeeId.Email = updateEmployeeDto.Email;
            employeeId.Phone = updateEmployeeDto.Phone;
            employeeId.Salary = updateEmployeeDto.Salary;

            dbContext.SaveChanges();

            return Ok(employeeId);
        }

        [HttpDelete]
        public IActionResult DeleteEmployees(Guid id) 
        { 
            var employee = dbContext.Employee.Find(id);

            if(employee is null)
            {
                return NotFound();
            }

            dbContext.Employee.Remove(employee);
            dbContext.SaveChanges();
            return Ok();
        }
    }
}
