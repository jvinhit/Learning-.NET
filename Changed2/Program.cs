using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Changed2
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> openWtihs = new Dictionary<string, string>();
            openWtihs.Add("vinh", "Trang");
            openWtihs.Add("truong", "Thuy");
            openWtihs.Add("khai", "Diem");

            try
            {
                openWtihs.Add("vinh", "Trangs");
            }
            catch (Exception)
            {
                Console.WriteLine("An Element Key already exixts");
            }

            Console.WriteLine("For the key = \"vinh\" - value = {0}", openWtihs["vinh"]);
            openWtihs["khai"] = "Dung";
            try
            {
                Console.WriteLine("For the key =\"asd\" - value = {0}", openWtihs["asd"]);
            }
            catch (Exception)
            {
                Console.WriteLine("The key not found ");
            }

            string value = "";
            if (openWtihs.TryGetValue("vinh", out value))
            {
                Console.WriteLine("For the key = \"vinh\" - value = {0}", value);

            }
            else
            {
                Console.WriteLine("Key =\"vinh\" is not found");
            }


            if (!openWtihs.ContainsKey("vn"))
            {
                openWtihs.Add("vn", "vietnam");
                Console.WriteLine("Value added for key = ", openWtihs["vn"]);
            }
            Console.WriteLine();
            foreach (KeyValuePair<string, string> index in openWtihs)
            {
                Console.WriteLine("Key = {0}, Value = {1}", index.Key, index.Value);

            }

            Dictionary<string, string>.ValueCollection valueColl = openWtihs.Values;
            Console.WriteLine();
            foreach (string s in valueColl)
            {
                Console.WriteLine("value = {0}", s);
            }

            Dictionary<string, string>.KeyCollection keyColl = openWtihs.Keys;

            foreach (var s in keyColl)
            {
                Console.WriteLine(s);
            }


            List<Dictionary<string, int>> MyList = new List<Dictionary<string, int>>();

            MyList.Add(new Dictionary<string, int>());
            MyList.Add(new Dictionary<string, int>());

            MyList[0].Add("Dictionary 1", 1);
            MyList[0].Add("Dictionary 2", 2);


            MyList[1].Add("Dictionary 1", 3);
            MyList[1].Add("Dictionary 2", 4);

            //MyList[1].Add("Dictionary 1", 1);
            //MyList[1].Add("Dictionary 1", 2);
            //MyList[1].Add("Dictionary 2", 3);
            //MyList[1].Add("Dictionary 2", 4);

            foreach (var dictionary in MyList)
                foreach (KeyValuePair<string, int> keyValue in dictionary)
                    Console.WriteLine(string.Format("{0} {1}", keyValue.Key, keyValue.Value));





        }
        private List<KeyValuePair<string, int>> return_list_of_dictionary()
        {

            List<KeyValuePair<string, int>> _list = new List<KeyValuePair<string, int>>();

            Dictionary<string, int> _dictonary = new Dictionary<string, int>()
        {
            {"Key1",1},
            {"Key2",2},
            {"Key3",3},
        };



            foreach (KeyValuePair<string, int> i in _dictonary)
            {
                _list.Add(i);
            }

            return _list;

        }


    }
    public class DictionaryCollection<TType> : Dictionary<string, Dictionary<string, TType>>
    {
        public void Add(string dictionaryKey, string key, TType value)
        {

            if (!ContainsKey(dictionaryKey))
                Add(dictionaryKey, new Dictionary<string, TType>());

            this[dictionaryKey].Add(key, value);
        }

        public TType Get(string dictionaryKey, string key)
        {
            return this[dictionaryKey][key];
        }
    }
}
