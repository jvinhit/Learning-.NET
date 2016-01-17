using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Book1
{
    internal class Program
    {
        private static void Main(string[] args)
        {

            int DecCounter = 0, PICounter = 0, DocCounter = 0, CommentCounter = 0;
            int ElementCounter = 0, AttributeCounter = 0, TextCounter = 0, WhitespaceCounter = 0;
            XmlTextReader reader = new XmlTextReader(@"C:/books.xml");

            while (reader.Read())
            {
                XmlNodeType nodetype = reader.NodeType;
                Console.WriteLine("Xml Node Type: "+ nodetype.ToString());
                switch (nodetype)
                {
                    case XmlNodeType.XmlDeclaration:
                        DecCounter++;
                        break;
                    case XmlNodeType.ProcessingInstruction:
                        PICounter++;
                        break;
                    case XmlNodeType.DocumentType:
                        DocCounter++;
                        break;
                    case XmlNodeType.Comment:
                        CommentCounter++;
                        break;
                    case XmlNodeType.Element:
                        ElementCounter++;
                        if (reader.HasAttributes)
                            AttributeCounter += reader.AttributeCount;
                        break;
                    case XmlNodeType.Text:
                        TextCounter++;
                        break;
                    case XmlNodeType.Whitespace:
                        WhitespaceCounter++;
                        break;
                }
            }
// print the info
            Console.WriteLine("White Spaces:" + WhitespaceCounter.ToString());
            Console.WriteLine("Process Instruction:" + PICounter.ToString());
            Console.WriteLine("Declaration:" + DecCounter.ToString());
            Console.WriteLine("White Spaces:" + DocCounter.ToString());
            Console.WriteLine("Comments:" + CommentCounter.ToString());
            Console.WriteLine("Attributes:" + AttributeCounter.ToString());

          



            // Create a new File c:\xmlWriterTest.xml
            XmlTextWriter writer = new XmlTextWriter("D:\\ xmlWriterTest.xml", null);

            // opens the document
            writer.WriteStartDocument();

            // write comments
            writer.WriteComment("This Program uses XmlTextWriter.");
            writer.WriteComment("Developed by :Mahesh Chand.");
            writer.WriteComment("= = = = = = = = = = = = = = =");

            // write first element
            writer.WriteStartElement("root");
            writer.WriteStartElement("r", "RECORD", "urn: record");

            // write next element 
            writer.WriteStartElement("FirstName", " ");
            writer.WriteString("Mahesh");
            writer.WriteEndElement();

            // write one more element
            writer.WriteStartElement("LastName", " ");
            writer.WriteString("Chand");
            writer.WriteEndElement();
            XmlTextReader readers = new XmlTextReader(@"C:/books.xml");

            // Create an XmlTextReader to read books.xml
            while (readers.Read())
            {
                if (readers.NodeType == XmlNodeType.Element)
                {
                    // Add node.xml to xmlWriterTest.xml using WriteNode
                    writer.WriteNode(readers, true);
                }
            }
            // Ends the document.
            writer.WriteEndDocument();
            writer.Close();
            return;

        }
    }
}
