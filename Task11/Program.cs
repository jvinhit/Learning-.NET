using System;

namespace Task11
{

    class Program
    {
        static void Main(string[] args)
        {
            // спроба записати строку
            var textToFile = new TextToFile("string.txt", "Some string for writing to file");
            var fi = new FileInterface(textToFile);
            fi.SaveTextItem();
            Console.WriteLine();

            //спроба записати Customer
            var customer = new Customer("Ivan", "Ivanov", new DateTime(1990, 12, 11), "+380 78 456 78 67", "ivanov@gmail.com",
                "SS 345876", 1234567812345678, new DateTime(2012, 3, 12));
            var customerToFile = new CustomerToFile("customer.txt", customer);
            var fi1 = new FileInterface(customerToFile);
            fi1.SaveCustomerItem();

            Console.ReadKey();
        }
    }
}
