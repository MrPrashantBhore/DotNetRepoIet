using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemos
{
    class Program
    {
        public delegate void mydelgate(int value);

        //// method "Do1" 
        //public static void Do1(int a)
        //{
        //    Console.WriteLine("Product = {0}", (a * a));
        //}
        //delegate declaration
        public delegate void OperationDel(int a, int b);

        //mul delegate
        public delegate void rectDelegate(double height,
                                  double width);

        // method "sum" 
        public static void sum(int a, int b)
        {
            Console.WriteLine("Sum= {0}", (a + b));
        }

        
        // method "mul" 
        public static void Multiply(int a, int b)
        {
            Console.WriteLine("Product = {0}", (a*b));
        }


        // "area" method 
        public static void area(double height, double width)
        {
            Console.WriteLine("Area is: {0}", (width * height));
        }

        // "perimeter" method 
        public static void perimeter(double height, double width)
        {
            Console.WriteLine("Perimeter is: {0} ", 2 * (width + height));
        }

        public static void traingleArea(double height, double width)
        {
            Console.WriteLine("trainagle Area is: {0} ", 0.5 * (width + height));
        }
        static void Main(string[] args)
        {
            //singlecast Delagtes
            //creating object of del
            OperationDel del1 = new OperationDel(sum);
            OperationDel del2 = Multiply;

            //del1(3, 4); //invoke as next line
            //del1.Invoke(8, 9);
            //del2(4, 5);

            //multicast Delagtes
            rectDelegate rectdelObj = new rectDelegate(area);
            rectdelObj += perimeter;
            rectdelObj += traingleArea;

            rectdelObj.Invoke(6.3, 4.2);

            rectdelObj -= traingleArea;
            rectdelObj.Invoke(6.3, 4.2);
            //Anonymous methods
            mydelgate print = delegate (int val) {
                Console.WriteLine("Inside Anonymous method. Value: {0}", val);
            };

            print(100);


            Console.WriteLine("Done");
            Console.ReadLine();
        }
    }
}
