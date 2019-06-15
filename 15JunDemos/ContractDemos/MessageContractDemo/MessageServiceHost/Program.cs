using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace MessageServiceHost
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting service wait");
            ServiceHost host = new ServiceHost(typeof(CalculatorService));
            host.Open();
            Console.WriteLine(" service is up now");
            Console.WriteLine("service running at" + host.BaseAddresses[0].ToString());
            Console.WriteLine("Hit any key to stop service");
            Console.ReadLine();
            host.Close();
        }
    }
}
