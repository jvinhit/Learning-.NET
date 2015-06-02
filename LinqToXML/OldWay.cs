using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace LinqToXML
{
    public class OldWay
    {
        private static XmlDocument m_doc = new XmlDocument();

        public static void CreateEmployees()
        {
            XmlElement root = m_doc.CreateElement("employees");
            root.AppendChild(AddEmployee(1, "Gustavo Achong", DateTime.Parse("7/31/1996"), false));
            root.AppendChild(AddEmployee(3, "Kim Abercrombie", DateTime.Parse("12/12/1997"), true));
            root.AppendChild(AddEmployee(8, "Carla Adams", DateTime.Parse("2/6/1998"), false));
            root.AppendChild(AddEmployee(9, "Jay Adams", DateTime.Parse("2/6/1998"), false));

            m_doc.AppendChild(root);
           
            Console.WriteLine(m_doc.OuterXml);
        }

        private static XmlElement AddEmployee(int ID, string name, DateTime hireDate, bool isSalaried)
        {
            XmlElement employee = m_doc.CreateElement("employee");
            
            XmlElement nameElement = m_doc.CreateElement("name");
            nameElement.InnerText = name;
            
            XmlElement hireDateElement = m_doc.CreateElement("hire_date");
            hireDateElement.InnerText = hireDate.ToShortDateString();

            employee.SetAttribute("id", ID.ToString());
            employee.SetAttribute("salaried", isSalaried.ToString());
            employee.AppendChild(nameElement);
            employee.AppendChild(hireDateElement);

            return employee;
        }

        public static void Casting()
        {
            XmlDocument doc = new XmlDocument();
            XmlElement root = doc.CreateElement("employees");
            XmlElement employee = doc.CreateElement("employee");

            XmlElement nameElement =  doc.CreateElement("name");
            nameElement.InnerText = "Jay Adams";
            employee.AppendChild(nameElement);

            XmlElement idElement =  doc.CreateElement("id");
            
            // Must be string, or converted to string
            //idElement.InnerText = 42;
            idElement.InnerText = "42";

            employee.AppendChild(idElement);

            root.AppendChild(employee);
            doc.AppendChild(root);

            // Cannot convert type 'string' to 'int'
            // No explict cast available
            //int id = (int)idElement.Value;

            int id = Convert.ToInt32(idElement.Value);
        }

        public static void GetElments()
        {
            XmlElement root = m_doc.CreateElement("employees");
            root.AppendChild(AddEmployee(1, "Gustavo Achong", DateTime.Parse("7/31/1996"), false));
            root.AppendChild(AddEmployee(3, "Kim Abercrombie", DateTime.Parse("12/12/1997"), true));
            root.AppendChild(AddEmployee(8, "Carla Adams", DateTime.Parse("2/6/1998"), false));
            root.AppendChild(AddEmployee(9, "Jay Adams", DateTime.Parse("2/6/1998"), false));

            m_doc.AppendChild(root);

            foreach(XmlNode node in m_doc.DocumentElement.ChildNodes)
            {
                Console.WriteLine(node.ToString());
            }

        }
    }
}
