using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Callbackdel
{
    class Program
    {
        //example 2 - pass del as parameter
        public delegate void PrintDel(int value);

        

        static void Main(string[] args)
        {
            
                                 
            //why delegate
            First.myLengthyMethod(CallbackNumberDisplay);


            //pass param
            PrintHelper(PrintNumber, 5000);
            PrintHelper(PrintMoney, 9000);
            Console.ReadLine();
        }

        //--------------------for long running delegate

        public static void CallbackNumberDisplay(int num)
        {
           Console.WriteLine("Number is " ,num);
        }

       }