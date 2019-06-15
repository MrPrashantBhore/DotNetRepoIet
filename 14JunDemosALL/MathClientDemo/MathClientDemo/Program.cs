
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathClientDemo.MathProxy;

namespace MathClientDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Started");
            InvokeService();
            Console.WriteLine("Done");
            Console.WriteLine("To stop service hit any key");
            Console.ReadLine();
        }

        public static void InvokeService()
        {

            MathProxy.MathClient proxy = new MathClient();
            Console.WriteLine("now watch the service method invocation ");
            Console.WriteLine("Sum ={0}", proxy.Addition(2,7) );
            Console.WriteLine("Sum={0}", proxy.Multiply(2, 7));

        }
    }
}
