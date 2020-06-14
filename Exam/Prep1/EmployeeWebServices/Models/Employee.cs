﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeWebServices.Models
{
    public class Employee
    {
        [Key]
        public string Name { get; set; }
        public double HourlyWage { get; set; }
        public double HoursPerMonth { get; set; }


        public double GetMonthlyPay()
        {
            double pay = 0;
            if (HoursPerMonth > 150)
            {
                pay = 150 * HourlyWage;
                var tmpHours = HoursPerMonth - 150;
                pay += tmpHours * (HourlyWage * 1.5);
            }
            else
            {
                pay = HoursPerMonth * HourlyWage;
            }

            return pay;
        }
    }
}
