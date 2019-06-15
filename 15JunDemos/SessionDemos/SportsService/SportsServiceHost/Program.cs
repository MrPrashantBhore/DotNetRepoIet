using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
namespace SportsServiceHost
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost host = new ServiceHost(typeof(SportsService.Service1));
            host.Open();
            Console.WriteLine("service running at" + host.BaseAddresses[0].ToString());
            Console.ReadLine();
        }
    }
}
