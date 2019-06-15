using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
namespace SportsClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("now consuming service");
            DemoClient();
            Console.WriteLine("Done");
            Console.WriteLine("hit any key to stop");
            Console.ReadLine();
        }
        public static void DemoClient()
        {

            BasicHttpBinding basicHttpBinding = new BasicHttpBinding();

            var serviceUrl = "http://localhost:9595/SportsService/GetDetails";

            var endpoint = new EndpointAddress(serviceUrl);

            var channelFactory = new ChannelFactory<ISportsDetails>(basicHttpBinding, endpoint);

            ISportsDetails serviceSports = channelFactory.CreateChannel(endpoint);
            var list = serviceSports.ListSports();
            foreach (var sport in list)
            {
                Console.WriteLine("Sports={0}", sport);

            }
        }
    }
}
