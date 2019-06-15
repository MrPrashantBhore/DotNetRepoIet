using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
namespace netTcpClientDemo
{
    [ServiceContract]
    public interface IHelloService
    {
        [OperationContract]
        string DoWork(string nm);
    }
    class Program
    {
        static void Main(string[] args)
        {
            NetTcpBinding binding = new NetTcpBinding();
            EndpointAddress addr = new EndpointAddress("net.tcp://localhost:5000/demotcp");
            ChannelFactory<IHelloService> chn = new ChannelFactory<IHelloService>(binding, addr);
            IHelloService obj = chn.CreateChannel();
            Console.WriteLine(obj.DoWork("Omkara.....!!!"));
            Console.WriteLine("Done");
            Console.ReadLine();
        }
    }
}
