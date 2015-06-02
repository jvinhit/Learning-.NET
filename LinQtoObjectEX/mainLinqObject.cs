using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQtoObjectEX
{
    class mainLinqObject
    {
        #region khoi tao du lieu
        // Datasource
        static List<Contact> contacts = Contact.SampleData();
        static List<CallLog> callogs = CallLog.SampleData();
        static List<Customers> customers = Customers.SampledataCustomer();
        static List<Order> orders = Order.SampleDataOrder();
        #endregion
        #region vidu truy van
        // return a list of formated strings based on data from a query over a collection of Contact record
        public static void ex1()
        {

            var q = from c in contacts
                    where c.DateOfBirth.AddYears(50) > DateTime.Now
                    orderby c.DateOfBirth descending
                    select string.Format("Ho van ten: {0} {1} - b.{2}", c.FirstName, c.LastName, c.DateOfBirth.ToString("dd-MMM-yyyy"));

            foreach (string s in q)
            {
                Console.WriteLine(s);
            }
        }

        //Query group Contact record into sub-collection based on their state
        public static void ex2()
        {
            var q2 = from c in contacts
                     group c by c.State;
            foreach (var queck in q2)
            {
                Console.WriteLine(queck.Count(st => st.State == "WA"));
                Console.WriteLine("State: " + queck.Key);
                foreach (var quack in queck)
                {
                    Console.WriteLine(quack.State + " " + quack.LastName);
                }
            }
        }
        // Join two collections : Contact and Callog by phone number.
        public static void ex3()
        {
            var joinCC = from contact in contacts
                         join callog in callogs on contact.Phone equals callog.Number
                         select new
                         {
                             callog.When,
                             contact.FirstName,
                             contact.LastName,
                             callog.Duration,
                             contact.Phone
                         };
            foreach (var c in joinCC)
            {
                Console.WriteLine("{0} - {1} {2} ({3})min == {4}", c.When.ToString("ddMMM HH:m"), c.FirstName, c.LastName, c.Duration, c.Phone);
            }

        }
        //incoming call log summary show filter, oder, join and select aggregate
        public static void ex4()
        {
            var joinoderfilterCC = from call in callogs
                                   where call.Incoming == true
                                   group call by call.Number into g
                                   join contact in contacts on g.Key equals contact.Phone
                                   orderby contact.FirstName, contact.LastName
                                   select new
                                   {
                                       Ho = contact.FirstName,
                                       Ten = contact.LastName,
                                       Dem = g.Count(),
                                       Avg = g.Average(c => c.Duration),
                                       Total = g.Sum(c => c.Duration)
                                   };
            foreach (var jofCC in joinoderfilterCC)
            {
                Console.WriteLine("{0}  {1}  - Calls: {2}, Time: {3}mins, Avg: {4}", jofCC.Ho, jofCC.Ten, jofCC.Dem, jofCC.Total, Math.Round(jofCC.Avg, 2));
            }
        }
        // using : let
        public static void ex5()
        {
            int[] source = new int[] { 1, 2, 2, 2, 2, 2, 3, 4, 5, 6, 7 };
            var exlet = from s in source
                        let vinh = source.Average()
                        select Math.Pow((s - vinh), 2);
            foreach (var chan in exlet)
            {
                Console.WriteLine(chan);
            }


        }
        // into
        public static void ex6()
        {
            int[] source = new int[] { 1, 2, 2, 2, 2, 2, 3, 4, 5, 6, 7 };
            //var exinto = from s in source
            //             group s by s into groups
            //             select new
            //             {
            //                 Key = groups.Key,
            //                 Count = groups.Count()
            //             };

            var exinto = from s in source
                         group s by s into groups
                         where groups.Count() == 5
                         let trungbinh = groups.Average()
                         select new { GT = trungbinh / 2 };
            foreach (var thich in exinto)
            {
                Console.WriteLine(thich.GT);
            }

        }
        // Style query
        public static void ex7()
        {
            // Style query option : 
            // Extension method 
            // query expression syntax.
            //Ex: Query get all contact in the state of "WA" ordered by lastname and  then first name using  extension method query syntax
            var exEM = contacts.Where(c => c.State == "WA").OrderBy(c => c.LastName.Length).ThenBy(c => c.FirstName);
            foreach (var yeu in exEM)
            {
                Console.WriteLine(yeu.FirstName);
            }
            // query expression syntax: 
            var exEM1 = from contact in contacts
                        where contact.State == "WA"
                        orderby contact.FirstName, contact.LastName
                        select contact;
        }
        //join extension method query
        public static void ex8()
        {
            var exJoins = callogs.Join(contacts, call => call.Number, contact => contact.Phone,
               (call, contact) => new
               {
                   contact.FirstName,
                   contact.LastName,
                   call.When,
                   call.Duration
               }).OrderByDescending(call => call.When).Take(5);
            foreach (var call in exJoins)
                Console.WriteLine("{0} - {1} {2} ({3}min)",
                call.When.ToString("ddMMM HH:m"),
                call.FirstName, call.LastName, call.Duration);
        }
        // join query expression
        public static void ex9()
        {
            var exJoins1 = (from call in callogs
                            join contact in contacts on call.Number equals contact.Phone
                            orderby call.When descending
                            select new { contact.FirstName, contact.LastName, call.When, call.Duration }).Take(5);

            foreach (var call in exJoins1)
                Console.WriteLine("{0} - {1} {2} ({3}min)",
                call.When.ToString("ddMMM HH:m"),
                call.FirstName, call.LastName, call.Duration);
        }

        // select many
        public static void ex10()
        {
            string[] mangstring = new string[] {
                "nguyen van vinh","yeu duong thi xuan thuy","hoang mai thao","yeu nguyen van vinh"
            };
            // option 1 : use select clause 
            IEnumerable<string[]> option1 = mangstring.Select(chuoitrongmangstring => chuoitrongmangstring.Split(' '));
            Console.WriteLine("Count option1 : {0}", option1.Count());
            Console.WriteLine("----------");
            foreach (var mang in option1)
            {
                Console.WriteLine("Mang hold {0} elements", mang.Length);
                foreach (string s in mang)
                {
                    Console.WriteLine(s);
                }
            }
            // -> option2 : use SelectMany 
            Console.WriteLine("-----------OPtion2");
            IEnumerable<string> option2 = mangstring.SelectMany(s => s.Split(' '));

            foreach (string chuoi in option2)
            {
                Console.WriteLine(chuoi);
            }

        }
        // HOW to get the index position of the result 
        public static void ex11()
        {
            var q = callogs.GroupBy(g => g.Number).OrderBy(g => g.Count()).
                Select((g, index) => new
                {
                    number = g.Key,
                    rank = index + 1,// because Select and Select many start from sezo
                    count = g.Count()
                });

            foreach (var c in q)
            {
                Console.WriteLine("Rank {0} - {1}, called {2} times.", c.rank, c.number, c.count);
            }

        }
        // How to remove duplicate result
        // Using distinct
        public static void ex12()
        {
            string[] names = new string[] { "Peter", "Paul", "Mary", "Peter", "Paul", "Vinh" };
            // query using distinct
            var q = names.Select((s, index) => index < 3);
            foreach (var res in q)
            {
                Console.WriteLine(res);
            }
        }
        // ex2 about get index in the result
        public static void ex13()
        {
            var s = callogs.Select((g, index) => new { chiso = index + 1, Durationss = g.Duration, SoPhone = g.Number });
            foreach (var s1 in s)
            {
                Console.WriteLine("{0} - {1} time {2} ", s1.chiso, s1.SoPhone, s1.Durationss);
            }
        }
        #endregion
        /*Sorting  the result : 
        Using Orderby, thenby operator  sort in an ascending( a to z)
        Using OrderbyDescending , ThenByDescending sort in descending ( z  to a)
        CHi duy nhat 1 lan sap xep ket qua trong linq thi dung Orderby , neu lon hon 1 lan ta dung them thenby
        */
        /*
            [source].OrderBy([w]).
                    .ThenBydescending([x]).
                    .ThenBy([y])
         !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            from [v] in [source]
            orderby [w], [x]descenfing,[y]
            select[z] 
         */

        public static void sortingex1()
        {
            int[] mangInts = new int[] { 1, 3, 2, 4, 6, 5, 8, 7, 10, 9 };
            var mSort = mangInts.OrderBy(x => x);
            var mSortDes = mangInts.OrderByDescending(x => x);

            //.ThenByDescending(x => x % 2 == 0)
            //.ThenBy(y => y);
            List<int> listInts = mangInts.ToList();
            Console.WriteLine("Sorting order by ( a - z)");
            foreach (var element in mSort)
            {
                Console.Write(element + "→");
            }
            Console.WriteLine();
            Console.WriteLine("Sorting Orderby Descending: ");
            foreach (var element in mSortDes)
            {
                Console.Write(element + "→");
            }
            Console.WriteLine();
            Console.WriteLine("Sorting nhung phan tu chan");
            var mChan = listInts.OrderByDescending(x => (x % 2 != 0));
            foreach (var element in mChan)
            {
                Console.Write(element + "→ ");

            }
            Console.WriteLine();

        }


        /*how to GROUP elements:*/
        /*ex15: group all Contact by State.*/
        #region Group example
        public static void ex15()
        {
            var q = from c in contacts
                    group c by c.State;
            var q2 = contacts.GroupBy(delegate(Contact contact)
            {
                return contact.State;
            });
            //var q2 = contacts.GroupBy(s => s.State,s=> s.LastName);

            foreach (var s in q2)
            {
                Console.WriteLine(s.Key + "----");
                foreach (var elements in s)
                {
                    Console.WriteLine(elements.State + "->" + elements.FirstName + " - " + elements.LastName);
                    //Console.WriteLine(elements);
                }

            }
        }
        public static void ex16()
        {
            string[] partNumber = new string[] { "thuy", "thuy2", "vinh", "vinh1", null, null };
            //var q = from p in partNumber
            //        group p by p.Substring(0, 2);
            var q = from p in partNumber
                    group p by p == null ? "(null)" : p.Substring(0, 3);
            foreach (var s in q)
            {
                Console.WriteLine("Group key: {0}", s.Key);
                foreach (var s1 in s)
                {
                    Console.WriteLine("   {0}", s1);
                }
            }
        }

        //Group elements can be projected to new type ( tham tso thu 2 trong cau lenh group)
        public static void ex17()
        {

            var q = contacts.GroupBy(c => c.State, c => c.FirstName + " " + c.LastName);
            foreach (var p in q)
            {
                Console.WriteLine("Group Key : {0}", p.Key);
                foreach (var s in p)
                {
                    Console.WriteLine(s);
                }
            }
        }
        // Group by composite key (more than one value)
        // Anonymous type can be used to group by more than one value
        public static void ex18()
        {
            var qg = from q in contacts
                     group q by new { q.LastName, q.State }; // Group by two value : LastName and State
            foreach (var s in qg)
            {
                Console.WriteLine("Group - {0} , {1} - count= {2}", s.Key.LastName, s.Key.State, s.Count());

            }
        }

        // Su dung ket qua cua group trong cau truy van
        public static void ex20()
        {
            var q = from call in callogs
                    group call by call.Number into g
                    select new
                    {
                        Number = g.Key,
                        InCalls = g.Count(c => c.Incoming),
                        OutCalls = g.Count(c => !c.Incoming),
                        TotalTime = g.Sum(c => c.Duration),
                        AgeTime = g.Average(c => c.Duration)
                    };// ket qua trong cau lenh group de dua vao

            foreach (var number in q)
            {
                Console.WriteLine("{0} ({1} in,{2} out) Avg Time: {3} mins", number.Number, number.InCalls, number.OutCalls, Math.Round(number.AgeTime, 2));
            }
        }
        #endregion
        #region Join example
        // Cross join : 
        public static void ex21()
        {
            var outer = Enumerable.Range(1, 3);
            var inner = Enumerable.Range(4, 3);

            var q = from x in outer
                    from y in inner
                    select new { x, y };
            foreach (var element in q)
            {
                Console.WriteLine(element.x + "_" + element.y);
            }

            var ljoin = outer.SelectMany(x => inner, (x, y) => new { x, y });

        }
        public static void ex23()
        {
            int[] binary = new int[] { 0, 1 };
            var q = from b4 in binary
                    from b3 in binary
                    from b2 in binary
                    from b1 in binary
                    select string.Format("{0}{1}{2}{3}", b4, b3, b2, b1);

            foreach (var ps in q)
            {
                Console.WriteLine(ps);
            }
        }

        public static void ex24()
        {
            string[] outer = new string[] { "a", "b", "c", "d" };
            string[] inner = new string[] { "b", "c", "d", "e" };
            var truyvan = from s1 in outer
                          join s2 in inner on s1 equals s2
                          select string.Format("Outer {0}-  Inner: {1}", s1, s2);
            foreach (string s in truyvan)
            {
                Console.WriteLine(s);
            }
        }
        //
        public static void ex25()
        {
            var query = from o in orders
                        join c in customers on o.CustomerID equals c.CustomerID
                        select new { MaHD = o.OrderNumber, Ten = c.LastName };
            foreach (var kh in query)
            {
                Console.WriteLine("ONum: {0} - Name: {1}", kh.MaHD, kh.Ten);
            }
        }
        public static void ex26()
        {
            var query = from c in customers
                        join o in orders on c.CustomerID equals o.CustomerID into j// su dung into de cat ket qua join hoac truy van nao do xong ta se dung lai
                        from order in j.DefaultIfEmpty()
                        select new { Ten = c.LastName, Ma = order };
            foreach (var element in query)
                Console.WriteLine(
                "Customer: {0} Order Number: {1}",
                element.Ten.PadRight(9, ' '),
                element.Ma == null ?
                "(no orders)" : element.Ma.OrderNumber);


        }

        // Join composite key More than one value
        public static void ex27()
        {
            List<Contact> outer = Contact.SampleData();
            List<CallLog> inner = CallLog.SampleData();
            var query = from contact in outer
                        join call in inner on // Join bang nhieu key dung tu khoa new
                        new
                        {
                            phone = contact.Phone //,
                            //contact.Extenstion 
                        }
                        equals
                         new
                         {
                             phone = call.Number//, 
                             //call.Extension..
                         }
                        select new { call, contact };
        }

        // Join subquery use SingleOrDefault '
        // SingleOrDefault : Trả về một phần tử phù hợp từ tập hợp kia hoặc null nếu không có sự phù hợp.

        public static void ex28()
        {
            var query = from o in orders
                        select new
                        {
                            OrderNum = o.OrderNumber,
                            Ten = (from c in customers
                                   where c.CustomerID == o.CustomerID
                                   select c.LastName).SingleOrDefault()
                        };
            foreach (var ten in query)
            {
                Console.WriteLine("Customer: {0}, OrderNumber :  {1}", ten.Ten, ten.OrderNum);
            }
        }
        public static void ex30()
        {
            var q3 = from o in orders
                     let cust = customers
                     .SingleOrDefault(
                     c => c.CustomerID == o.CustomerID)
                     select new
                     {
                         OrderNumber = o.OrderNumber,
                         LastName = cust.LastName
                     };
            foreach (var order in q3)
            {
                Console.WriteLine("Customer: {0} Order Number: {1}", order.LastName.PadRight(9, ' '),
order.OrderNumber);
            }
        }

        /*ONE TO MANY JOIN*/c
        // Use join./into key
        public static void ex31()
        {
            var q1 = from c in customers
                     join o in orders on c.CustomerID equals o.CustomerID
                                        into cust_orders
                     select new
                     {
                         LastName = c.LastName,
                         Orders = cust_orders
                     };
            foreach (var customer in q1)
            {
                Console.WriteLine("Last name: {0}", customer.LastName);
                foreach (var order in customer.Orders)
                    Console.WriteLine(" - Order number: {0}", order.OrderNumber);
            }
        }
        // Su dung ToLookup: 

        #endregion
        #region where clause filter result
        // using where filter by index position ( a ,index) => index % 2 ==0) :)
        public static void ex22()
        {
            int[] mangInt = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var s = mangInt.Where((a, index) => (index % 2 == 0));
            foreach (var odd in s)
            {
                Console.WriteLine("Odd in s is {0}", odd);
            }
        }
        #endregion


        static void Main(string[] args)
        {
            //ex1();
            //ex2();
            //ex3();
            //ex4();
            //ex5();
            //ex6();
            //ex7();
            //ex8();
            //ex9();
            //ex10();
            //ex11();
            //ex12();
            //ex13();
            //Sort with orderby ... 
            //RandomShuffleStringSort<string> he = new RandomShuffleStringSort<string>();
            //he.ex14();
            //ex15();
            //ex16();
            //ex17();
            //ex18();
            //EqualsUseWithGroup.ex19();
            //ex20();
            //ex21();
            //ex22();
            //sortingex1();
            //ex23();
            //ex24();
            //ex25();
            //ex26();
            //ex28();
            //ex30();
            /*JOin one to many*/
            ex31();

        }


    }
}
