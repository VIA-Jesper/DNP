﻿using System;

namespace Exercise202_Polymorphism
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



            Console.WriteLine(company.GetMonthlySalaryTotal());


        }
    }
}
