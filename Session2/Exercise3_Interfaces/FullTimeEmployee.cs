﻿namespace Exercise203_Interfaces
{
    class FullTimeEmployee : Employee
    {


        private readonly double monthlySalary;

        public FullTimeEmployee(string name, double monthlySalary) : base(name)
        {
            this.monthlySalary = monthlySalary;
        }

        public override double GetMonthlySalary()
        {
            return monthlySalary;
        }
    }
}
