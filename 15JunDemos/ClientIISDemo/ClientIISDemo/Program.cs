using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClientIISDemo.proxyIIS;
namespace ClientIISDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wait Invokign Service");
            proxyIIS.Service1Client obj = new Service1Client();
            Console.WriteLine(obj.Add(2,4));
            Console.WriteLine("Done");
            Console.WriteLine("hit any key to close");
            Console.ReadLine();
          

        }
    }
}
