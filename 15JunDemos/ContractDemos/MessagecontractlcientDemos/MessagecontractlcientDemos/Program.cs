﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MessagecontractlcientDemos.CalculatorProxy;
namespace MessagecontractlcientDemos
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a client with given client endpoint configuration
            CalculatorClient client = new CalculatorClient();

            // Perform addition using a typed message.

            MyMessage request = new MyMessage();
            request.N1 = 100D;
            request.N2 = 15.99D;
            request.Operation = "+";
            MyMessage response = ((ICalculator)client).Calculate(request);
            Console.WriteLine("Add({0},{1}) = {2}", request.N1, request.N2, response.Result);

            // Perform subtraction using a typed message.

            request = new MyMessage();
            request.N1 = 145D;
            request.N2 = 76.54D;
            request.Operation = "-";
            response = ((ICalculator)client).Calculate(request);
            Console.WriteLine("Subtract({0},{1}) = {2}", request.N1, request.N2, response.Result);

            // Perform multiplication using a typed message.

            request = new MyMessage();
            request.N1 = 9D;
            request.N2 = 81.25D;
            request.Operation = "*";
            response = ((ICalculator)client).Calculate(request);
            Console.WriteLine("Multiply({0},{1}) = {2}", request.N1, request.N2, response.Result);

            // Perform multiplication using a typed message.

            request = new MyMessage();
            request.N1 = 22D;
            request.N2 = 7D;
            request.Operation = "/";
            response = ((ICalculator)client).Calculate(request);
            Console.WriteLine("Divide({0},{1}) = {2}", request.N1, request.N2, response.Result);

            //Closing the client gracefully closes the connection and cleans up resources
            Console.WriteLine("closign client");

            client.Close();
            Console.WriteLine("Press <ENTER> to terminate client.");
         
            Console.ReadLine();
        }
    }
}
