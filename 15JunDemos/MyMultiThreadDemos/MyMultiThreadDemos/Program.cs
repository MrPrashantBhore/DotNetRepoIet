using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace MyMultiThreadDemos
{
    class Program
    {
        public static void Thread1Method()
        {
            Thread.Sleep(1000);
            Console.WriteLine("I am task one of thread1");
        }
        public static void Thread2Method()
        {
            Console.WriteLine("I am task two of thread2");
        }

        static void Main(string[] args)
        {
            Thread t1 = new Thread(new ThreadStart(Thread1Method));
            Thread t2 = new Thread(new ThreadStart(Thread2Method));
            t1.Start();
            t2.Start();
            Console.WriteLine("Done");
            Console.ReadLine();
        }
    }
}
