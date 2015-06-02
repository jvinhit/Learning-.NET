using System;
using System.IO;

namespace Task11
{
    class TextToFile
    {
        public string FileName { get; set; }
        public string Text { get; set; }

        public TextToFile(string file, string text)
        {
            FileName = file;
            Text = text;
        }

        public void HandleFileOversizing(object sender, MessageArgs args) //для обробки події при переповненні файлу
        {
            Console.WriteLine(FileName + " " + args.DisplayMessage);
            Console.WriteLine("If you want to save some data in the file , press <Y>, otherwise the entry in the file is not going to happen!");
            if(Convert.ToChar(Console.ReadLine().ToUpper()) == 'Y')
            {
                writeSomeDataToFile(args.DataInBytes);
                readSomeDataFromFile();
            }
        }

        public void writeSomeDataToFile(byte[] bytes) //запис даних у файл
        {
            using (var fs = new FileStream(FileName, FileMode.OpenOrCreate))
            {
                fs.Write(bytes, 0, bytes.Length);
            }
        }

        public void readSomeDataFromFile() //зчитуємо усі дані з файлу
        {
            using (var fs = new StreamReader(FileName))
            {
                Console.WriteLine("Your data -> {0}",fs.ReadToEnd());
            }
        }
    }
}
