using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace LinqToXML
{
    public class NewWay
    {
        /// <summary>
        /// Create a sample document
        /// </summary>
        public static void CreateEmployees()
        {
            XDocument doc = new XDocument(
            // To use a XElement the XDeclaration and XCooment can't be used
            //XElement doc = new XElement(
                new XDeclaration("1.0", "utf-8", "yes"),
                new XComment("A sample xml file"),
                new XElement("employees",
                    new XElement("employee",
                        new XAttribute("id", 1),
                        new XAttribute("salaried", "false"),
                            new XElement("name", "Gustavo Achong"),
                            new XElement("hire_date", "7/31/1996")),
                    new XElement("employee",
                        new XAttribute("id", 3),
                        new XAttribute("salaried", "true"),
                            new XElement("name", "Kim Abercrombie"),
                            new XElement("hire_date", "12/12/1997")),
                    new XElement("employee",
                        new XAttribute("id", 8),
                        new XAttribute("salaried", "false"),
                            new XElement("name", "Carla Adams"),
                            new XElement("hire_date", "2/6/1998")),
                    new XElement("employee",
                        new XAttribute("id", 9),
                        new XAttribute("salaried", "false"),
                            new XElement("name", "Jay Adams"),
                            new XElement("hire_date", "2/6/1998"))
                        )
                       );

            Console.WriteLine(doc.ToString());

            // The XDeclaration doesn't show up in the console
            // window, so save the file for review to prove it
            // is there
            doc.Save(@"f:\test.xml");
        }

        /// <summary>
        /// Demonstrate the creation of an XElement
        /// as an independent element, not tied to
        /// a document
        /// </summary>
        public static void SingleEmployee()
        {
            XElement employee = new XElement("employee",
                        new XAttribute("id", 1),
                        new XAttribute("salaried", "false"),
                            new XElement("name", "Gustavo Achong"),
                            new XElement("hire_date", "7/31/1996"));

            Console.WriteLine(employee.ToString());
        }

        /// <summary>
        /// Demonstrate loading xml from a file
        /// </summary>
        public static void LoadEmployees()
        {
            XElement employees = XElement.Load("../../sample.xml");

            Console.WriteLine(employees.ToString());
        }

        /// <summary>
        /// Demonstrate using a namespace with a
        /// XML document
        /// </summary>
        public static void WithNamespace()
        {
            XNamespace ns = "http://mycompany.com";

            XElement doc = new XElement(
                 new XElement(ns + "employees",
                     new XElement("employee",
                         new XAttribute("id", 1),
                         new XAttribute("salaried", "false"),
                             // Note here that a namespace is not supplied on these
                             // elements. This will cause an emoty namespace to be
                             // included
                             new XElement("name", "Gustavo Achong"),
                             new XElement("hire_date", "7/31/1996")),
                     new XElement(ns + "employee",
                         new XAttribute("id", 3),
                         new XAttribute("salaried", "true"),
                             new XElement("name", "Kim Abercrombie"),
                             new XElement("hire_date", "12/12/1997")),
                     new XElement(ns + "employee",
                         new XAttribute("id", 8),
                         new XAttribute("salaried", "false"),
                             new XElement("name", "Carla Adams"),
                             new XElement("hire_date", "2/6/1998")),
                     new XElement(ns + "employee",
                         new XAttribute("id", 9),
                         new XAttribute("salaried", "false"),
                             new XElement("name", "Jay Adams"),
                             new XElement("hire_date", "2/6/1998"))
                         )
                        );
            Console.WriteLine(doc.ToString());

        }

        /// <summary>
        /// Demonstrate using two namespaces
        /// </summary>
        public static void WithNamespaceWithPrefix()
        {
            XNamespace ns1 = "http://mycompany.com";
            XNamespace ns2 = "http://somecompany.com";

            XElement doc = new XElement(
                  new XElement(ns1 + "employees",
                  new XAttribute(XNamespace.Xmlns + "ns1", ns1),
                     new XElement(ns2 + "employee",
                         new XAttribute("id", 1),
                         new XAttribute("salaried", "false"),
                         new XAttribute(XNamespace.Xmlns + "ns2", ns2),
                             new XElement(ns2 + "name", "Gustavo Achong"),
                             new XElement(ns2 + "hire_date", "7/31/1996")),
                     new XElement(ns2 + "employee",
                         new XAttribute("id", 3),
                         new XAttribute("salaried", "true"),
                         new XAttribute(XNamespace.Xmlns + "ns2", ns2),
                             new XElement(ns2 + "name", "Kim Abercrombie"),
                             new XElement(ns2 + "hire_date", "12/12/1997")),
                     new XElement(ns2 + "employee",
                         new XAttribute("id", 8),
                         new XAttribute("salaried", "false"),
                         new XAttribute(XNamespace.Xmlns + "ns2", ns2),
                            new XElement(ns2 + "name", "Carla Adams"),
                             new XElement(ns2 + "hire_date", "2/6/1998")),
                     new XElement(ns2 + "employee",
                         new XAttribute("id", 9),
                         new XAttribute("salaried", "false"),
                         new XAttribute(XNamespace.Xmlns + "ns2", ns2),
                             new XElement(ns2 + "name", "Jay Adams"),
                             new XElement(ns2 + "hire_date", "2/6/1998"))
                         )
                        );
            Console.WriteLine(doc.ToString());

        }

        /// <summary>
        /// Demonstrate explict conversion of datatypes 
        /// </summary>
        public static void Casting()
        {
            XElement element1 = new XElement("number", 42);
            // It doesn't matter it the value is a string or int
            XElement element2 = new XElement("number", "42");

            int num1 = (int)element1;
            int num2 = (int)element2;
        }

        /// <summary>
        /// Demonstrate iteration of an XML document
        /// </summary>
        public static void TraverseTree()
        {
            XDocument doc = CreateEmployeesPrivate();

            Console.WriteLine("-- All nodes --");

            // Iterate over all nodes
            foreach(var node in doc.Nodes())
            {
                Console.WriteLine(node);
            }
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("-- XElement nodes --");

            // Iterate over the XElement nodes
            foreach(var node in doc.Nodes().OfType<XElement>())
            {
                Console.WriteLine(node);
            }
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("-- XComment nodes --");

            // Iterate over only the XComment nodes
            foreach(var node in doc.Nodes().OfType<XComment>())
            {
                Console.WriteLine(node);
            }

            Console.WriteLine(Environment.NewLine);

            Console.WriteLine("-- Employee name nodes --");

            // Iterate over only the XComment nodes
            foreach(var node in doc.Elements("employees").Elements("employee").Elements("name"))
            {
                Console.WriteLine(node);
            }
        }

        /// <summary>
        /// Demonstrate create a new XElement from a query
        /// </summary>
        public static void CreateFromQuery()
        {
            XDocument doc = CreateEmployeesPrivate();

            // Order the employee elements by hire date and select
            // the first one as the newest employee
            var newElement = doc.Descendants("employee").Select(e => e).OrderBy(e => DateTime.Parse((string)e.Element("hire_date"))).First();

            // Create an element from the above query
            XElement element = new XElement("newest_hire", newElement);

            Console.WriteLine(element);
        }

        /// <summary>
        /// Demonstrate creating a new XElment from a direct query
        /// </summary>
        public static void Transform()
        {
            XDocument doc = CreateEmployeesPrivate();

            // Use query expression to find all salaried employees
            // and create a new XElement with their name(s)
            XElement element = new XElement("salaried_employees", from e in doc.Descendants("employee")
                                                where e.Attribute("salaried").Value == "true"
                                                select new XElement("employee",
                                                    new XElement(e.Element("name")) )
                                                );
            Console.WriteLine(element);
        }


        #region Private methods
        
        /// <summary>
        /// Private method to create an XML document
        /// for use in other methods.
        /// This is seperate from the CreateEmployees static
        /// method to allow the former to be manipulated for demo
        /// purposes, whithout effecting other methods
        /// </summary>
        /// <returns></returns>
        private static XDocument CreateEmployeesPrivate()
        {
            XDocument doc = new XDocument(
                new XDeclaration("1.0", "utf-8", "yes"),
                new XComment("A sample xml file"),
                new XElement("employees",
                    new XElement("employee",
                        new XAttribute("id", 1),
                        new XAttribute("salaried", "false"),
                            new XElement("name", "Gustavo Achong"),
                            new XElement("hire_date", "7/31/1996")),
                    new XElement("employee",
                        new XAttribute("id", 3),
                        new XAttribute("salaried", "true"),
                            new XElement("name", "Kim Abercrombie"),
                            new XElement("hire_date", "12/12/1997")),
                    new XElement("employee",
                        new XAttribute("id", 8),
                        new XAttribute("salaried", "false"),
                            new XElement("name", "Carla Adams"),
                            new XElement("hire_date", "2/6/1998")),
                    new XElement("employee",
                        new XAttribute("id", 9),
                        new XAttribute("salaried", "false"),
                            new XElement("name", "Jay Adams"),
                            new XElement("hire_date", "2/6/1998"))
                        )
                       );

            return doc;
        }

        #endregion
    }
}
