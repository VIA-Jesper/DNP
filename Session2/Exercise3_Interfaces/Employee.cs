﻿namespace Exercise203_Interfaces
{
    internal abstract class Employee
    {

        private string name;

        public Employee(string name)
        {
            this.name = name;
        }

        
        public abstract double GetMonthlySalary();

    }
}