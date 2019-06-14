using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.IO;
namespace linqXMLDemos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Started");
            // Demo1();
            //SaveXML();
           QueryXMlData();
            Console.WriteLine("Done");
            Console.WriteLine("Press any key to exit");
            Console.ReadLine();
        }

        public static void Demo1()
        {
            //LINQ-to-XMl supports "Functional cosntuction Approach"
            XElement contacts =
                new XElement("Contacts",
                    new XElement("Contact",
                    new XElement("Name", "Patrick Hines"),
                    new XElement("Phone", "206-555-0144"),
                    new XElement("Address",
                        new XElement("Street1", "123 Main St"),
                        new XElement("City", "Mercer Island"),
                        new XElement("State", "WA"),
                        new XElement("Postal", "68042"))));
            Console.WriteLine(contacts);

           
        }

        public static void SaveXML()
        {

            StringBuilder sb = new StringBuilder();
            XmlWriterSettings xws = new XmlWriterSettings();
            xws.OmitXmlDeclaration = true;
            xws.Indent = true;

            XmlWriter xw = XmlWriter.Create(sb, xws);
            XDocument doc = new XDocument(new XElement("Child",new XElement("GrandChild", "some content")));
            doc.WriteTo(xw);
             Console.WriteLine(sb.ToString());


           
            XDocument doc3 = new XDocument(
                new XElement("Contacts",
                    new XElement("Contact",
                    new XElement("Name", "Patrick Hines"),
                    new XElement("Phone", "206-555-0144"),
                    new XElement("Address",
                        new XElement("Street1", "123 Main St"),
                        new XElement("City", "Mercer Island"),
                        new XElement("State", "WA"),
                        new XElement("Postal", "68042"))))
                 );
            doc3.Save("C:\\SportsApplication\\cust.xml");
            Console.WriteLine(File.ReadAllText("C:\\SportsApplication\\cust.xml"));
        }

        public static void QueryXMlData()
        {
            XElement root = XElement.Load("C:\\SportsApplication\\PurchaseOrder.xml");
            IEnumerable<XElement> address =
                from el in root.Elements("Address")
                where (string)el.Attribute("Type") == "Billing"
                select el;

            foreach (XElement el in address)
                Console.WriteLine(el);


            Console.WriteLine("Querying tree loaded with XDocument.Load");
            Console.WriteLine("----");
            XDocument doc = XDocument.Load("C:\\SportsApplication\\PurchaseOrder.xml");
            IEnumerable<XElement> childList =
                from el in doc.Elements()
                select el;
            foreach (XElement e in childList)
                Console.WriteLine(e);



            Console.WriteLine("Querying tree loaded with XElement.Load");
            Console.WriteLine("----");
            XElement docele = XElement.Load("C:\\SportsApplication\\PurchaseOrder.xml");
            IEnumerable<XElement> childList1 =
                from el in docele.Elements()
                select el;
            foreach (XElement e in childList1)
                Console.WriteLine(e);
        }
    }
}
