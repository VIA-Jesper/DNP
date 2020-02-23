using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise203_Interfaces
{
    class PartTimeStudent : PartTimeEmployee, IStudent
    {
        private int year;
        public PartTimeStudent(string name, double hourlyWage, int hoursPerMonth) : base(name, hourlyWage, hoursPerMonth)
        {
            
        }

        public void Register(int year)
        {
            this.year = year;
        }
    }
}
