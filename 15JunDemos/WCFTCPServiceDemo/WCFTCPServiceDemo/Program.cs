using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace WCFTCPServiceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            DemoService();
        }

        public static void DemoService()
        {
            ServiceHost host = new ServiceHost(typeof(HelloService));

            NetTcpBinding binding = new NetTcpBinding();

            host.AddServiceEndpoint(typeof(IHelloService), binding, new Uri("net.tcp://localhost:5000/demotcp"));

            host.Open();
            Console.WriteLine("Started service");
            Console.WriteLine("service running  ");
            Console.WriteLine("To stop");
            Console.ReadLine();
        }
    }
}
