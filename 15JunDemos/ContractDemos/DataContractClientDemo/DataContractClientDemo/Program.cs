using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataContractClientDemo.employeeProxy;
// http://localhost:9000/HrProcessing/EmpService
namespace DataContractClientDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Callign Service");
            employeeProxy.EmpServiceClient obj = new EmpServiceClient();
            employeeProxy.Employee emp = new employeeProxy.Employee();
            emp.FirstName = "Shirley";
            emp.LastName = "Teens";
            emp.Gender = "Female";

            employeeProxy.Employee empObj2 = obj.GetDataUsingDataContract(emp);
            Console.WriteLine("Result obtained from service as below");
            Console.WriteLine(empObj2.Details);
            Console.WriteLine("Oh I am done");
            Console.WriteLine("To Stop hit any key");  
            Console.ReadLine();

        }
    }
}
