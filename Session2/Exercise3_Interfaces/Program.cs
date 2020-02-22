using System;
using Exercise3_Interfaces;

namespace Exercise3_Interfacess
{
    class Program
    {
        static void Main(string[] args)
        {
            Company company = new Company();


            Employee emp1 = new FullTimeEmployee("test1", 35000);
            company.EmployNewEmployee(emp1);
            Employee emp2 = new PartTimeEmployee("test2", 350, 125);
            company.EmployNewEmployee(emp2);
            Employee emp3 = new FullTimeEmployee("test3", 35000);
            company.EmployNewEmployee(emp3);
            PartTimeStudent stud = new PartTimeStudent("Stud1", 115, 60);
            company.EmployNewEmployee(stud);

            Console.WriteLine(company.GetMonthlySalaryTotal());
        }
    }
}
