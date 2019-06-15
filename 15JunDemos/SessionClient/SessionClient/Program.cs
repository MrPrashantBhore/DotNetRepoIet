using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SessionClient.Proxy;
namespace SessionClient
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Service1Client obj1 = new Service1Client();
            Service1Client proxy1 = new Service1Client();
            Console.WriteLine("----------------------------- 1st Output by Proxy 1-----------------------------");
            Console.WriteLine(proxy1.GetData().ToString());

            Console.WriteLine("----------------------------- 2nd Output by Proxy 1-----------------------------");
            Console.WriteLine(proxy1.GetData().ToString());


            Console.WriteLine(" -----------------------------3rd Output by Proxy 1-----------------------------");
            Console.WriteLine(proxy1.GetData().ToString());

            Service1Client proxy2 = new Service1Client();
            Console.WriteLine("-----------------------------1st Output by Proxy 2-----------------------------");
            Console.WriteLine(proxy2.GetData().ToString());

            Console.WriteLine("----------------------------- 2nd Output by Proxy 2-----------------------------");
            Console.WriteLine(proxy2.GetData().ToString());

            Console.WriteLine("----------------------------- 3rd Output by Proxy 2-----------------------------");
            Console.WriteLine(proxy2.GetData().ToString());

            Service1Client proxy3 = new Service1Client();
            Console.WriteLine("-----------------------------1st Output by Proxy 3-----------------------------");
            Console.WriteLine(proxy3.GetData().ToString());



            Console.WriteLine(" 2nd Output by Proxy 3 ");
            Console.WriteLine(proxy3.GetData().ToString());


            Console.WriteLine(" 3rd Output by Proxy 1 ");
            Console.WriteLine(proxy3.GetData().ToString());
            Console.WriteLine("done");
            Console.ReadLine();
        }
    }
}
