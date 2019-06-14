using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//              generic interface
namespace CoolelctionDemos
{
    using System;

    public interface IMyGenericInterfce<T>
    {
       void Method1(T a, T b);
       T Method2(T a, T b);
    }
      
    public class MyClass : IMyGenericInterfce<int>
    {

        public void Method1(int a, int b)
        { Console.WriteLine("Sum=",(a+b)); }

        public int Method2(int a, int b)
        { return (a * b); }

    }

    public interface IMyGenericSwapInterfce<T>
    {
        void Swap(ref T a, ref T b);
        
    }

    class mygenSwap<T> : IMyGenericSwapInterfce<T>
    {
        public void Swap(ref T a, ref T b)
        {
            Console.WriteLine("After swap");
            Console.WriteLine("n1={0} \t n2={1}", a, b);
            T temp;
            temp = a;
            a = b;
            b = temp;
            Console.WriteLine("After swap");
            Console.WriteLine("n1={0} \t n2={1}",a,b);
        }
    }

    

}
