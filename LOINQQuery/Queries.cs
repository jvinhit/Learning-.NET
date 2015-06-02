using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOINQQuery
{
    class Queries
    {
        public static void print(IEnumerable<Student> students)
        {
            foreach (var item in students)
            {
                Console.WriteLine(item);
            }
        }
        public static bool FirstNameCheck(Student studentss)
        {
            if (studentss.Name == "Thao")
            {
                return true;
            }
            else
                return false;
        }
        static void Main(string[] args)
        {
            var oop = new Course { Id = 1, Name = "OOP" };
            var javaScript = new Course { Id = 2, Name = "JavaScript" };
            var cSharp = new Course { Id = 3, Name = "C#" };
            var html = new Course { Id = 4, Name = "HTML" };
            var students = new List<Student>
            {
                new Student 
                {
                    Id = 1 ,
                    Name = "Vinh",
                    DateOfBirth = new DateTime(1990,12,3),
                    Cources = new List<Course>{oop,cSharp}
                },
                 new Student 
                {
                    Id = 2 ,
                    Name = "Thuy",
                     DateOfBirth = new DateTime(1990,12,3),
                    Cources = new List<Course>{javaScript,cSharp,html}
                },
                 new Student 
                {
                    Id = 3 ,
                    Name = "Thao",
                     DateOfBirth = new DateTime(1990,12,3),
                    Cources = new List<Course>{html}
                },
                 new Student 
                {
                    Id = 4 ,
                    Name = "Diem",
                     DateOfBirth = new DateTime(1990,12,3),
                    Cources = new List<Course>{cSharp}
                },
                new Student 
                {
                    Id = 5 ,
                    Name = "Thao",
                     DateOfBirth = new DateTime(1991,2,3),
                    Cources = new List<Course>{html,cSharp,javaScript}
                }

            };

            // USING where
            var studentsWithFirtNameV = students.Where(st => st.Name.StartsWith("V"));
            //print(studentsWithFirtNameV);

            // id  > 3 && course > 2
            var studentss = students.Where(st => st.Id > 1 && st.Cources.Count > 2);
            //print(studentss);


            // First Lay ra gia tri dau tien nhung phai ton tai, neu ko ton tai * tuc la bang null * se bao loi
            // TRuong hop do len su dung first or default

            Student firtsWithNameVinh = students.FirstOrDefault(st => st.Name == "Vinhsd");
            //if (firtsWithNameVinh == null)
            //{
            //    Console.WriteLine("Khong co sinh vien nao ten Vinhsd");
            //}
            //else
            //{
            //    Console.WriteLine(firtsWithNameVinh);
            //}
            //string studentName = "Thao";
            //Student lastStudentNameThao = students.LastOrDefault(st => st.Name == studentName);
            Student lastStudentNameThao = students.LastOrDefault(FirstNameCheck);
            //Console.WriteLine(lastStudentNameThao);
            //-------------------------------------------------
            // select to int : 
            var courseCount = students.Select(st => st.Cources.Count);
            foreach (var courseCounst in courseCount)
            {
                //Console.WriteLine(courseCounst);
            }
            List<int> CourseCount = new List<int>();
            foreach (var student in students)
            {
                CourseCount.Add(student.Cources.Count);
            }

            //select to class
            var selectToClass = students
                .Select(st => new SortStudentInfo
                {
                    Name = st.Name,
                    CourseCount = st.Cources.Count,
                });

            //Select to  ann Type
            var onlyStudentAndCourseCount = students
                .Where(st => st.Id > 2)
                .Select(st => new
                {
                    Name = st.Name,
                    CourseCount = st.Cources.Count
                });
            foreach (var stinfo in onlyStudentAndCourseCount)
            {
                Console.WriteLine(stinfo);
            }
            // Cast enum value : cast enum to string in c# using google search

            //var colors =
            //Enum.GetValues(typeof(ColorEnum)).OfType<int>().Cast<string>();
            var colors =
         Enum.GetValues(typeof(ColorEnum)).Cast<ColorEnum>().Select(x => x.ToString());
            foreach (var color in colors)
            {
                Console.WriteLine(color);
            }

            // order by student by year
            var sortYears = students.OrderBy(st => st.DateOfBirth.Year);
            print(sortYears);
            // Order by more thing 
            var sortByNameThenByYear
            =
            students.OrderBy(st => st.Name).
            ThenBy(st => st.DateOfBirth.Year);
            print(sortByNameThenByYear);
            // Any
            bool SomeinJavaScript =
                students.Any(st => st.Cources.Any(c => c.Name == "JavaScript"));
            Console.WriteLine(SomeinJavaScript);
            // anyone with year >= 2000
            bool atLeast2000 = students.Any(st => st.DateOfBirth.Year >= 2000);

            Console.WriteLine(atLeast2000);

            // cast to array
            Student[] arrayStudent = students.ToArray();
            List<Student> listStudent = students.ToList();
            // Reverse 
            students.Reverse();
            print(students);
            //student with max course
            int maxCourse = students.Max(st => st.Cources.Count);
            
            // Min student id 
            int minstudentID = students.Min(st => st.Id);
            // Sum student Year BD
            int sumYEar = students.Sum(st => st.DateOfBirth.Year);

            // 
            double avarageActive = students.Where(st => st.Cources.Count > 0).Average(st => st.DateOfBirth.Year);
            // 
            int CountActive = students.Count(st => st.Cources.Count > 2);

            // Some 
            var someCollection = students.Where(st => st.Id > 2 || st.DateOfBirth.Year > 1990).OrderBy(st => st.Cources.Count).
                ThenBy(st => st.Name).Select(st => new
                {
                    FirstNameSymbol = st.Name[0],
                    Year = st.DateOfBirth.Year,
                }).ToList();

            foreach(var st in someCollection)
            {
                Console.WriteLine(st);
            }

            string tessst = "vi---11 nh";
            Console.WriteLine(tessst.ToLowerInvariant());
            Console.WriteLine(tessst.ToUpperInvariant());

        }
    }
}
