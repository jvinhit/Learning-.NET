using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    public class Employee
    {
        public int salary;
        public Employee(int annualSalary)
        {
            salary = annualSalary;

        }
        public Employee(int weekSalary,int NumberofWeek)
        {
            salary = weekSalary * NumberofWeek;
        }

    }
    public class Manager:Employee
    {
        public Manager(int annualSalary):base(annualSalary)
        {

        }
        public Manager(int weeklySalary, int numberOfWeeks)
            : base(weeklySalary, numberOfWeeks)
        {

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Manager managerA = new Manager(30000);
            Manager managerB = new Manager(500, 52);
            Console.WriteLine("Annual Salary: {0}\nWeekly Salary: {1}", managerA.salary, managerB.salary);
        }
    }
}
