using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel.Description;
using GettingStartedLib;
using System.ServiceModel;

namespace GettingStartedHost
{
    

    class Program
   {
       static void Main(string[] args)
       {
           Demo();
       }
        //Host using using configuration
       public static void Demo()
       {
           // Step 1: Create a URI to serve as the base address.
           Uri baseAddress = new Uri("http://localhost:8000/GettingStarted/");
           // Step 2: Create a ServiceHost instance.
           ServiceHost selfHost = new ServiceHost(typeof(CalculatorService), baseAddress);
           try
           {
               // Step 3: Add a service endpoint.
               selfHost.AddServiceEndpoint(typeof(ICalculator), new WSHttpBinding(), "CalculatorService");

               // Step 4: Enable metadata exchange.
               ServiceMetadataBehavior smb = new ServiceMetadataBehavior();
               smb.HttpGetEnabled = true;
               selfHost.Description.Behaviors.Add(smb);

               // Step 5: Start the service.
               selfHost.Open();
               Console.WriteLine("The service is ready. at {0}", selfHost.BaseAddresses[0].ToString());

               // Close the ServiceHost to stop the service.
               Console.WriteLine("Press <Enter> to terminate the service.");
               Console.WriteLine();
               Console.ReadLine();
               selfHost.Close();
           }
            catch (CommunicationException ce)
           {
               Console.WriteLine("An exception occurred: {0}", ce.Message);
               selfHost.Abort();
           }
       }
   }
}



