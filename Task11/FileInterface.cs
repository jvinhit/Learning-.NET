using System;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace Task11
{
    class FileInterface
    {
        public event EventHandler<MessageArgs> OnFileOversizing;

        private TextToFile textToFile;
        private CustomerToFile customerToFile;

        public FileInterface(TextToFile textToFile)
        {
            this.textToFile = textToFile;
            OnFileOversizing += textToFile.HandleFileOversizing;
        }

        public FileInterface(CustomerToFile customerToFile)
        {
            this.customerToFile = customerToFile;
            OnFileOversizing += customerToFile.HandleFileOversizing;
        }

        public void SaveTextItem() //метод для зберігання строковий даних
        {
            var unicode = new UnicodeEncoding();
            byte[] dataBytes = unicode.GetBytes(textToFile.Text);
            if (dataBytes.Length > 10)
            {
                byte[] newDataBytes = dataBytes.ToArray();
                Array.Resize(ref newDataBytes, 10);
                OnFileOversizing(this, new MessageArgs("File oversizing!", newDataBytes));
            }
            else
            {
                textToFile.writeSomeDataToFile(dataBytes);
                textToFile.readSomeDataFromFile();
            }
        }

        public void SaveCustomerItem() //метод для зберігання даних Customer
        {
            IFormatter formatter = new BinaryFormatter();
            var stream = new MemoryStream();
            formatter.Serialize(stream, customerToFile.CustomerItem);
            
            if (stream.Length > 350)
            {
                byte[] arraybytes = stream.ToArray();
                Array.Resize(ref arraybytes, 350);
                OnFileOversizing(this, new MessageArgs("File oversizing!", arraybytes));
            }
            else
            {
                customerToFile.writeSomeDataToFile(stream.ToArray());
                customerToFile.readSomeDataFromFile();
            }
        }
    }
}
