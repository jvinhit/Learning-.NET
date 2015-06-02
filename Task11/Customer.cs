using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Globalization;
using System.Runtime.Serialization;

namespace Task11
{
    [Serializable]
    public class Customer
    {
        public string Name{ get;set; }
        public string Surname { get;set; }
        public DateTime DayBirth { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Passport { get; set; }
        public long CardNumber { get; set; }
        public DateTime CardDate { get; set; }

        public Customer()
        {
        }

        public Customer(string name, string surname, DateTime dayBirth, string phone, string email, string passport, long cardNumber, DateTime cardDate)
        {
            Name = name;
            Surname = surname;
            DayBirth = dayBirth;
            Phone = phone;
            Email = email;
            Passport = passport;
            CardNumber = cardNumber;
            CardDate = cardDate;
        }

       public string FoundSurname(string strPattern)
        {
            if (Regex.IsMatch(Surname, strPattern, RegexOptions.IgnoreCase))
            {
                return string.Format("This surname is matching with pattern -> {0}",Surname);
            }
            return "No matches...";
        }

        public string FoundName(string strPattern)
        {
            if (Regex.IsMatch(Name, strPattern, RegexOptions.IgnoreCase))
            {
                return string.Format("This name is matching with pattern -> {0}", Name);
            }
            return "No matches...";
        }

        public class SortBySurname : IComparer<Customer>
        {
            public int Compare(Customer x, Customer y)
            {
                return String.Compare(x.Surname, y.Surname);
            }
        }

        public class SortByDateBirth : IComparer<Customer>
        {
            public int Compare(Customer x, Customer y)
            {
                return DateTime.Compare(x.DayBirth, y.DayBirth);
            }
        }

        public class SortByPhone : IComparer<Customer>
        {
            public int Compare(Customer x, Customer y)
            {
                return String.Compare(x.Phone, y.Phone);
            }
        }
    }
}
