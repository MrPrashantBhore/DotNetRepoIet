using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
namespace InstancindServiceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost host = new ServiceHost(typeof(Service1));
            host.Open();
            Console.WriteLine("running " + "\t" + host.BaseAddresses[0].ToString());
            Console.WriteLine("press");
            Console.ReadLine();
            host.Close();
        }
    }
}
