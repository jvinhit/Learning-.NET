using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOINQQuery
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Course> Cources { get; set; }

        public DateTime DateOfBirth { get; set; }

        public override string ToString()
        {
            return  this.Id + this.Name + " " + this.DateOfBirth.Year + " "+ this.DateOfBirth.Month + " " +this.DateOfBirth.Day +  " " + this.Cources.Count;
        }
    }
}
