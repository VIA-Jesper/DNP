using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using EmployeeWebServices.Data;
using EmployeeWebServices.Models;
using EmployeeWebServices.Service;

namespace EmployeeWebServices
{
    [Route("api")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly EmployeeContext _context;
        private readonly EmployeeService employeeService;

        public EmployeesController(EmployeeContext context, EmployeeService employeeService)
        {
            _context = context;
            this.employeeService = employeeService;
        }

        // GET: api/Employees
        [HttpGet]
        [Route("employees")]
        public async Task<ActionResult<IEnumerable<Employee>>> GetEmployee(bool hasOvertime)
        {
            return employeeService.FilterEmployeesBasedOnOvertime(await _context.Employee.ToListAsync(), hasOvertime);
        }


        // POST: api/Employees
        [HttpPost]
        [Route("employees")]
        public async Task<ActionResult<Employee>> PostEmployee(Employee employee)
        {
            _context.Employee.Add(employee);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (EmployeeExists(employee.Name))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetEmployee", new { id = employee.Name }, employee);
        }

        // GET: api/payments
        [HttpGet]
        [Route("payments")]
        public async Task<ActionResult<double>> GetPayment(bool hasOvertime)
        {
            return employeeService.GetTotalMonthlyExpense(employeeService.FilterEmployeesBasedOnOvertime(await _context.Employee.ToListAsync(), hasOvertime));
        }


        private bool EmployeeExists(string id)
        {
            return _context.Employee.Any(e => e.Name == id);
        }
    }
}
