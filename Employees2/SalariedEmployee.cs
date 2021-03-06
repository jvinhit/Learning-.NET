﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees2
{
    public class SalariedEmployee : Employee
    {
        private decimal weeklySalary;

        // four-parameter constructor
        public SalariedEmployee(string first, string last, string ssn,
           decimal salary)
            : base(first, last, ssn)
        {
            WeeklySalary = salary; // validate salary via property
        } // end four-parameter SalariedEmployee constructor

        // property that gets and sets salaried employee's salary
        public decimal WeeklySalary
        {
            get
            {
                return weeklySalary;
            } // end get
            set
            {
                if (value >= 0) // validation
                    weeklySalary = value;
                else
                    throw new ArgumentOutOfRangeException("WeeklySalary",
                       value, "WeeklySalary must be >= 0");
            } // end set
        } // end property WeeklySalary

        // calculate earnings; override abstract method Earnings in Employee
        public override decimal Earnings()
        {
            return WeeklySalary;
        } // end method Earnings          

        // return string representation of SalariedEmployee object
        public override string ToString()
        {
            return string.Format("salaried employee: {0}\n{1}: {2:C}",
               base.ToString(), "weekly salary", WeeklySalary);
        } // end method ToString                                      
    } // end class SalariedEmployee
}
