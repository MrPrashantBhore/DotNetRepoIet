using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
namespace ServicenettcpDemos
{
    [ServiceContract]
    public interface IHelloService
    {
        [OperationContract]
        string DoWork(string nm);
    }

    public class HelloService : IHelloService
    {
        string IHelloService.DoWork(string nm)
        {
            return "Welcome " + nm + " to the world of WCF";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost host = new ServiceHost(typeof(HelloService));

            NetTcpBinding binding = new NetTcpBinding();

            host.AddServiceEndpoint(typeof(IHelloService), binding, new Uri("net.tcp://localhost:5000/demotcp"));

            host.Open();
            Console.WriteLine("Started service");
            Console.WriteLine("service running at " + host.BaseAddresses.ToString());
            Console.WriteLine("To stop");
            Console.ReadLine();
        }
    }
}
