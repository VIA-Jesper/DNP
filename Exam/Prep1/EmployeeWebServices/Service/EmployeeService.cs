using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeWebServices.Models;

namespace EmployeeWebServices.Service
{
    public class EmployeeService
    {
        internal List<Employee> FilterEmployeesBasedOnOvertime(List<Employee> employees, bool hasOvertime)
        {
            if (hasOvertime)
            {
                var emp = employees.Where(x => x.HoursPerMonth > 150).ToList();
                return emp;
            }

            return employees.Where(x=>x.HoursPerMonth <= 150).ToList();
        }

        internal double GetTotalMonthlyExpense(List<Employee> employees)
        {
            return employees.Sum(x=>x.GetMonthlyPay());
        }
    }
}
