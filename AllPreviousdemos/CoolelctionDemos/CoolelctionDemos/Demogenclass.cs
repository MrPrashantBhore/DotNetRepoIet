using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoolelctionDemos
{
    public class GenericClass<T> where T : class
    {
        public T msg;
        public void genericMethod(T name, T location)
        {
            Console.WriteLine("{0}", msg);
            Console.WriteLine("Name: {0}", name);
            Console.WriteLine("Location: {0}", location);
        }
    }

}