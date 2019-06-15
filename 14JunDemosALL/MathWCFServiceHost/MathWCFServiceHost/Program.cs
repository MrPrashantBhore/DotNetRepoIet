using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
namespace MathWCFServiceHost
{
    class Program
    {
        static void Main(string[] args)
        {
            HostTheService();
            Console.ReadLine();
        }

        public static void HostTheService()
        {
            Console.WriteLine("wait serice is about to start");
            ServiceHost host = new ServiceHost(typeof(MathsService));
            host.Open();
            Console.WriteLine("Service started up and available at " + host.BaseAddresses[0].ToString());
            Console.WriteLine("To stop service hit any key");
            Console.ReadLine();
            host.Close();
        }
    }
}
