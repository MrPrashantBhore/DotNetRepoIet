using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuiltInGenDelegates
{
    class Program
    {
        static int Sum(int x, int y)
        {
            return x + y;
        }

        static string Demo(int x, int y)
        {
            return "Sum=" + (x + y);
        }

        static void Main(string[] args)
        {
            //last param is return type
            Func<int, int, int> add = Sum;

            int result = add(10, 10);

            Console.WriteLine(result);


            //last param is return type
            Func<int, int, string> mydemo = Demo;

            string res = Demo(10, 10);

            Console.WriteLine(res);

            //anonymous del
            Func<int> getRandomNumber = delegate ()
            {
                Random rnd = new Random();
                return rnd.Next(1, 100);
            };

            Console.WriteLine(getRandomNumber());
            //----------------
            //action del
            Print prnt = ConsolePrint;
            Console.WriteLine("result of action delegate is here ");
            prnt(10);

            //----------------
            //predicate del
            Predicate<string> isUpper = IsUpperCase;

            bool result1 = isUpper("hello world!!");

            Console.WriteLine(result1);
            //----------------------------------
            Console.ReadLine();
        }
        //action
        public delegate void Print(int val);

        static void ConsolePrint(int i)
        {
            Console.WriteLine(i);
        }


        //predicate
        static bool IsUpperCase(string str)
        {
            return str.Equals(str.ToUpper());
        }

    }
}
