using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microloand.API.Data;
using Microloand.API.Models;

namespace Microloand.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    // TODO: Secure this controller using [Authorize]
    public class EmployeesController : ControllerBase
    {
        private readonly AppDbContext _context;

        public EmployeesController(AppDbContext context)
        {
            _context = context;
        }

        // ===============================
        // 🔹 GET: Get All Employees
        // ===============================
        // TODO:
        // 1. Fetch all employees from database
        // 2. Return list using Ok()
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Implement GET all employees");
        }

        // ===============================
        // 🔹 POST: Create Employee
        // ===============================
        // TODO:
        // 1. Add employee to DbContext
        // 2. Save changes
        // 3. Return created employee
        [HttpPost]
        public IActionResult Create(Employee employee)
        {
            return Ok("Implement Create employee");
        }

        // ===============================
        // 🔹 PUT: Update Employee
        // ===============================
        // TODO:
        // 1. Find employee by id
        // 2. If not found → return NotFound()
        // 3. Update fields (Name, Role)
        // 4. Save changes
        [HttpPut("{id}")]
        public IActionResult Update(int id, Employee employee)
        {
            return Ok("Implement Update employee");
        }

        // ===============================
        // 🔹 DELETE: Delete Employee
        // ===============================
        // TODO:
        // 1. Find employee by id
        // 2. If not found → return NotFound()
        // 3. Remove employee
        // 4. Save changes
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok("Implement Delete employee");
        }
    }
}