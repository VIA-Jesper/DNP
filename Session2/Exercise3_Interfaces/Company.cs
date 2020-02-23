using System.Collections.Generic;

namespace Exercise203_Interfaces
{
    class Company
    {
        private List<Employee> employs = new List<Employee>();

        public double GetMonthlySalaryTotal()
        {
            double totalSalary = 0.0;
            foreach (var employee in employs)
            {
                totalSalary += employee.GetMonthlySalary();
            }
            return totalSalary;
        }

        public void EmployNewEmployee(Employee newEmployee)
        {
            employs.Add(newEmployee);
        }
    }

}
