using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Task11
{
    class CustomerToFile
    {
        public string FileName { get; set; }
        public Customer CustomerItem { get; set; }

        public CustomerToFile(string fileName, Customer customer)
        {
            FileName = fileName;
            CustomerItem = customer;
        }

        public void HandleFileOversizing(object sender, MessageArgs args) //для обробки події при переповненні файлу
        {
            Console.WriteLine(FileName + " " + args.DisplayMessage);
            Console.WriteLine("If you want to save some data in the file , press <Y>, otherwise the entry in the file is not going to happen!");
            if (Convert.ToChar(Console.ReadLine().ToUpper()) == 'Y')
            {
                writeSomeDataToFile(args.DataInBytes);
                try
                {
                    readSomeDataFromFile();
                }
                catch(SerializationException)
                {
                    Console.WriteLine("Your data is incorrect recorded");
                }
                catch(Exception ex)
                {
                    Console.WriteLine("Error -> {0}", ex.Message);
                }
            }
        }

        public void writeSomeDataToFile(byte[] bytes) // запис данних у файл
        {
            using (var fs = new FileStream(FileName, FileMode.OpenOrCreate))
            {
                fs.Write(bytes, 0, bytes.Length);
            }
        }

        public void readSomeDataFromFile() // зчитуємо з файлу дані
        {
            var bf = new BinaryFormatter();
            Customer customer;
            using (FileStream fs = File.OpenRead(FileName))
            {
                customer =  (Customer) bf.Deserialize(fs);
            }
            Console.WriteLine("Customer -> "+customer.Name +" "+customer.Surname +" "+customer.DayBirth +" "+
                customer.Email +" "+customer.Phone +" "+customer.Passport +" "+customer.CardNumber +" "+customer.CardDate);
        }
    }
}
