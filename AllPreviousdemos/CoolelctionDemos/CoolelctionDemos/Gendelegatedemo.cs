using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoolelctionDemos
{
    class Test
    { 
    public delegate T add<T>(T param1, T param2);

    //static void Main(string[] args)
    //{
    //    add<int> sum = AddNumber;

    //    Console.WriteLine(sum(10, 20));

    //    add<string> conct = Concate;

    //    Console.WriteLine(conct("Hello", "World!!"));
    //}

    public static int AddNumber(int val1, int val2)
    {
        return val1 + val2;
    }

    public static string Concat(string str1, string str2)
    {
        return str1 + str2;
    }

        public static string Concat2(int str1, int str2)
        {
            return (str1 + str2).ToString();
        }
    }
}
