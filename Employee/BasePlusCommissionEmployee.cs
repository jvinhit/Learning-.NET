using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    class BasePlusCommissionEmployee:CommissionEmployee
    {
        public decimal baseSalary;

        public BasePlusCommissionEmployee(string first, string last, string ssn, decimal sales, decimal rate,decimal baseSalary) : 
            base(first, last, ssn, sales, rate)
        {
            BaseSalary = baseSalary;
        }
        public decimal BaseSalary
        {
            get
            {
                return baseSalary;
            } // end get
            set
            {
                if (value >= 0)
                    baseSalary = value;
                else
                    throw new ArgumentOutOfRangeException("BaseSalary",
                       value, "BaseSalary must be >= 0");
            } 
        } // end property BaseSalary

        public override decimal Earnings()
        {
            return BaseSalary + base.Earnings();
        }

        public override string ToString()
        {
            return string.Format("base-salaried {0}\nbase salary: {1:C}",
               base.ToString(), BaseSalary);
        } // end method ToString
    }
}
