using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using WcfServiceLibrary1;
namespace DataContractDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Starting service is just a moment");
            ServiceHost host = new ServiceHost(typeof(WcfServiceLibrary1.EmployeeService));
            host.Open();
            Console.WriteLine("great now the servcie is runnig at " + host.BaseAddresses[0].ToString());
            Console.WriteLine("started service ");
            Console.WriteLine("to Stop hit any key");
            Console.ReadLine();

        }
    }
}
