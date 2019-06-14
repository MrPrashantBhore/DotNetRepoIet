using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomAttributesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Demo();
            Console.ReadLine();

        }

        public static void Demo()
        {
            Product  product = new Product();
            Type t = product.GetType();
           
            //Invoking Attributes in Student class 
            foreach (Attribute attrib in t.GetCustomAttributes(true))
            {
               //custAttribObj
                DevInfo custAttribObj = (DevInfo)attrib;
                Console.WriteLine("\n Developer name is::" + custAttribObj.DeveloperName + "\n");
                Console.WriteLine("\n Version number is::" + custAttribObj.VersionNo + "\n");
            }

        }
    }
}
