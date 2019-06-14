using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassLibrary1.Person obj = new Person() {FullName="ABC",Gender="male" };
            Console.WriteLine(obj.FullName);
        }
    }
}
