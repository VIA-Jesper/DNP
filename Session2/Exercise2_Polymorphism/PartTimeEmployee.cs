﻿namespace Exercise202_Polymorphism
{
    class PartTimeEmployee : Employee
    {
        private readonly double hourlyWage;
        private readonly int hoursPerMonth;

        public PartTimeEmployee(string name, double hourlyWage, int hoursPerMonth) : base(name)
        {
            this.hourlyWage = hourlyWage;
            this.hoursPerMonth = hoursPerMonth;
            
        }

        public override double GetMonthlySalary()
        {
            return hoursPerMonth * hourlyWage;
        }
    }
}
