using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace CoolelctionDemos
{
    class Program
    {
        static void Main(string[] args)
        {

            #region the demos from First class
            FirstDemo.DemoArrayList();
            FirstDemo.DemoStack();
            FirstDemo.DemoQueue();
            #endregion

            #region Collection interaface
            FirstDemo.CustomUseOfEnumerable();
            FirstDemo.UseofComparable();
         //   FirstDemo.UseofComparer();
            #endregion


            DemoHastable();

            UsingIenumerator();
            UsingIenumerable();
           
            UsingGenericList();
          
            FirstDemo.DemoEmployee();
            FirstDemo.usingDemoII();
            FirstDemo.DemoSwapping();
            Console.WriteLine("Done...................................");
            Console.ReadLine();
        }

        public static void UsingIenumerable()
        {
            Console.WriteLine("iterating collecions using IEnumerable");
            IEnumerable ienumObj = FirstDemo.GetAllSports();
            int i = 1;
            foreach (var item in ienumObj)
            {

                Console.WriteLine("Sport {0}--{1}", i, item.ToString());
                i += 1;
            }
        }

        public static void UsingIenumerator()
        {
            Console.WriteLine("iterating collecions using IEnumerator");
            IEnumerator ienumObj = FirstDemo.ListAllSports.GetEnumerator();
            int i = 1;
            while (ienumObj.MoveNext())
            {
                Console.WriteLine("Sport {0}--{1}", i, ienumObj.Current.ToString());
                i += 1;
            }
            
        }


        public static void DemoHastable()
        {
            // Console.WriteLine("iterating collecions using IEnumerator");
            Hashtable dict = FirstDemo.GetFruits;
            int i = 1;
            ICollection keys = dict.Keys;

            foreach (var k in keys)
            {
                Console.WriteLine(dict[k].ToString());
            }
            Console.WriteLine(dict.ContainsKey(1));
            Console.WriteLine(dict.ContainsValue("Mangoes"));
        }
        public static void UsingGenericList()
        {
            // Console.WriteLine("iterating collecions using IEnumerator");
            Console.WriteLine("Book Name\t Book Author\t Price");
            Console.WriteLine("--------------------------------------------");
            foreach (var book in FirstDemo.DemoGenList())
            {
                Console.WriteLine("{0}", book.ToString());
            }
        }


        








    }
}


