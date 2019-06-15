using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WcfServiceLibrary1;
using System.ServiceModel;
namespace TheHost
{
    class Program
    {
        static void Main(string[] args)
        {
         
            ServiceHost host = new ServiceHost(typeof(WcfServiceLibrary1.Service1));
            host.Open();
            Console.WriteLine("runnir " + "\t" + host.BaseAddresses[0].ToString());
            Console.WriteLine("press");
            Console.ReadLine();
            host.Close();

        }
    }
}
