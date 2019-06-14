using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLang
{
    class Program
    {
        public static void SquareIt(int x, out int result)
        {
            result = x * x;
        }
        static void Main(string[] args)
        {
            string s1 = "One";
            string s2 = "two";
            Console.WriteLine("Before call");
            Console.WriteLine(s1 + " " + s2);
            SwapStrings(ref s1, ref s2);
            Console.WriteLine("After call");


            // DecisionmakingDemo();
            LoopDemos();
            //int? x = null;
            Console.WriteLine("enter first number");
            int xNum1 = Convert.ToInt32(Console.ReadLine());
            #region done
            //const string subjectName= "Azure Dev";
            //Console.WriteLine("Started");
            //


            //int xNum2 = Convert.ToInt32(Console.ReadLine());
            ////int Result = xNum1 + xNum2; //or call
            //SumIT(xNum1, xNum2);

            //// Initialize with a regular string literal.
            //string oldPath = "c:\\Program Files\\MSVs8";

            //// Initialize with a verbatim string literal.
            //string newPath = @"c:\Program Files\MSVS9.0";

            //// Use System.String if you prefer.
            //string greeting = "Hello World!";

            //string s1 = "A string is more ";
            //string s2 = "than the sum of its chars.";


            //// Concatenate s1 and s2. This actually creates a new
            //// string object and stores it in s1, releasing the
            //// reference to the original object.
            //s1 += s2;

            //System.Console.WriteLine(s1);

            #endregion


            Console.WriteLine("Number1={0}\t Number{1}\t Result={2}", xNum1,xNum2,Result);
              SomeJagged();

            string[] weekDays = { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };
            ArrFunctionDemo(weekDays);

            EnumDemos();

            //out params
            int res;
              SquareIt(xNum1, out res);
            Console.WriteLine("Num={0}\t Square={1}", xNum1, res);
            //Console.WriteLine("enter second number");
            EnumDemos();
            Console.WriteLine("Done");
            Console.ReadLine();
        }
        public static void VarDemos()
        {
            string FullName = Console.ReadLine();
            Console.WriteLine("Welcome---{0}" + FullName);
            //Signed 32-bit integer	
            int xNum = 4;
            // //Signed 64-bit integer
            long longValue1 = 4294967296;
            Console.WriteLine(longValue1);

            //The float keyword signifies a simple type that stores 32-bit floating-point values. 
            int yNum = 3;
            float y = 4.5f;
            var calcValue = yNum * y;
            //The double keyword signifies a simple type that stores 64-bit floating-point values.
            bool b = true;
            if (b)
            {
                Console.WriteLine("now the value is true");
            }
            else
            { Console.WriteLine("The value is false"); }
        }
        public static void Additon()
        {
            int xNum1 = Convert.ToInt32(Console.ReadLine());
            int xNum2 = Convert.ToInt32(Console.ReadLine());
            int Result = xNum1 + xNum2;
            Console.WriteLine("Number1={0}\t Number{1}\t Result={2}", xNum1, xNum2, Result);
        }

        public static int SumIT(int xNum1, int xNum2)
        {
            return xNum1 + xNum2;
        }

        public static void DecisionmakingDemo()
        {
            Console.WriteLine("Enter Number");
            int num1 = Convert.ToInt32(Console.ReadLine());

            if (num1>0)
            {
                Console.WriteLine(" The enetered number {0} is positive number");
            }
            else
                if (num1 <0)
            {
                Console.WriteLine("Oops the enetered number {0} is negative number!!!!!");
            }
            else
            { Console.WriteLine("you entered zero");
            }
           
            //use of ternary operator
            int x = 20, y = 10;
            var result = x > y ? "x is greater than y" : "x is less than or equal to y";
            Console.WriteLine(result);
        }
        public static void LoopDemos()
        {
            //use of for loop
            for (int x = 1; x < 10; x+=2)
            {
                Console.WriteLine("Value of odd No = {0}", x);
            }
            Console.WriteLine("Starting from 10 , presenting the no in descending Order ");
            for (int j = 10; j > 0; j--)
            {
                Console.WriteLine("Number=: {0}", j);
            }

            Console.WriteLine("hey Now watch the output of while loop");
            int k = 0;

            while (true)
            {
                Console.WriteLine("Value of i: {0}", k);

               k++;

                if (k > 10)
                    break;
            }

            Console.WriteLine("hey Now watch the output of Do-while loop");
            int i = 0;

            do
            {
                Console.WriteLine("Value of i: {0}", i);

                i++;

            } while (i < 10);

        }
        public static void Arraydemos()
        {   //char array
            char[] chArr = new char[4];
            char[] letters = { 'A','B','C','D'};

            //String array
            string[] stringArray = new string[6];
            //delcare and initlialize
            string[] weekDays = new string[] { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };

            // Declare a single-dimensional integer array 
            int[] array1 = new int[5];
            //or delcare and initlialize
            //int[] array1 = new int[] { 1, 3, 5, 7, 9 };

            // Declare and set array element values
            int[] array2 = new int[] { 1, 3, 5, 7, 9 };

            //how to print array elements using foreach
            foreach (int item in array2)
            {
                Console.WriteLine("Num={0}\t",item);
            }

            //use fir loop
            for (int k = 0; k < array2.Length; k++)
            {
                Console.WriteLine("Element at {0} position is {1}\t",k,array2[k]);
            }
            // Alternative syntax shortcut
            int[] array3 = { 1, 2, 3, 4, 5, 6 };

            //int[] array2 = { 1, 3, 5, 7, 9 };
            string[] weekDays2 = { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };

            // Declare a two dimensional array
            //the following declaration creates a two-dimensional array of two rows and three columns.
            int[,] mdArray1 = new int[2, 3];
           
            // Declare and set array element values
            int[,] multiDimensionalArray2 = { { 1, 2, 3 }, { 4, 5, 6 } };

            int[,] arr1 = new int[3, 4] {
                        {0, 1, 2, 3} ,   /*  initializers for row indexed by 0 */
                        {4, 5, 6, 7} ,   /*  initializers for row indexed by 1 */
                        {8, 9, 10, 11}   /*  initializers for row indexed by 2 */
            };

            /* Delcare and print an array with 5 rows and 2 columns*/
            int[,] arr2 = new int[5, 2] { { 0, 0 }, { 1, 2 }, { 2, 4 }, { 3, 6 }, { 4, 8 } };
            int i, j;

            /* output each array element's value */
            for (i = 0; i < 5; i++)
            {

                for (j = 0; j < 2; j++)
                {
                    Console.WriteLine("a[{0},{1}] = {2}", i, j, arr2[i, j]);
                }
            }
           

           
        }

        public static void JagArrDemo()
        {
          
            //  jagged array is an array of an array. 
            //  Jagged arrays store arrays instead of any other data type value directly.
            //  A jagged array is initialized with two square brackets [][]. 
            //  The first bracket specifies the size of an array and the 
            //  second bracket specifies the dimension of the array 
            //  which is going to be stored as values. 
            //(Remember, jagged array always store an array.) 
            
           
            //int[][] jaggedArray = new int[3][];

            //jaggedArray[0] = new int[5];
            //jaggedArray[1] = new int[4];
            //jaggedArray[2] = new int[2];
            //---------------------------------------
            // Declare the array of two elements:
            int[][] arr = new int[2][];

            // Initialize the elements:
            arr[0] = new int[5] { 1, 3, 5, 7, 9 };
            arr[1] = new int[4] { 2, 4, 6, 8 };

            // Display the array elements:
            for (int i = 0; i < arr.Length; i++)
            {
                System.Console.Write("Element({0}): ", i);

                for (int j = 0; j < arr[i].Length; j++)
                {
                    System.Console.Write("{0}{1}", arr[i][j], j == (arr[i].Length - 1) ? "" : " ");
                }
                System.Console.WriteLine();
            }


            System.Console.WriteLine("Press any key to exit.");
            System.Console.ReadKey();
        }

        public static void SomeJagged()
        {
            // Declare the array of two elements:
            int[][] arr = new int[3][];

            // Initialize the elements:
            arr[0] = new int[5] { 1, 3, 5, 7, 9 };
            arr[1] = new int[4] { 2, 4, 6, 8 };
            arr[2] = new int[4] { 11, 44, 66, 88 };

            Console.WriteLine(arr[1][3]); // prints 8

            int[][,] jaggedArray4 = new int[3][,]
                {
                    new int[,] { {1,3}, {5,7} },
                    new int[,] { {0,2}, {4,6}, {18,10} },
                    new int[,] { {11,22}, {99,88}, {0,9} }
                };
            //zero the arrays 1 st rows 1st the element
            Console.WriteLine("{0}", jaggedArray4[0][1, 1]);//prints 7
            Console.WriteLine("{0}", jaggedArray4[1][2, 1]);//prints 10
        }
        //appssing array to function
        public static void ArrFunctionDemo(string[] weekdays)
        {
            foreach (string days in weekdays)
            {
                Console.WriteLine("Day={0}\t",days);
            }
        }
        //pass by ref
        // The string parameter is passed by reference.
        // Any changes on parameters will affect the original variables.
        static void SwapStrings(ref string s1, ref string s2)
        {
            string temp = s1;
            s1 = s2;
            s2 = temp;
            System.Console.WriteLine("Inside the method: {0} {1}", s1, s2);
        }
        //to invoke
        //string str1 = "John";
        //string str2 = "Smith";
        //System.Console.WriteLine("Inside Main, before swapping: {0} {1}", str1, str2);

        // SwapStrings(ref str1, ref str2);   // Passing strings by reference
        //System.Console.WriteLine("Inside Main, after swapping: {0} {1}", str1, str2);
     
           


        public static void EnumDemos()
        {
            Console.WriteLine(Enum.GetName(typeof(WeekDays), 4));
            Console.WriteLine("-------------------");
            Console.WriteLine("WeekDays constant names:");

            foreach (string str in Enum.GetNames(typeof(WeekDays)))
                Console.WriteLine(str);
            Console.WriteLine("-------------------");
        }

        public static void StructDemos()
        {
            // Initialize:   
            Coords coords1 = new Coords();
            Coords coords2 = new Coords(10, 10);

            // Display results:
            Console.Write("Coords 1: ");
            Console.WriteLine("x = {0}, y = {1}", coords1.x, coords1.y);

            Console.Write("Coords 2: ");
            Console.WriteLine("x = {0}, y = {1}", coords2.x, coords2.y);


            // Declare an object:
            Coords coords3;

            // Initialize:
            coords3.x = 10;
            coords3.y = 20;

            // Display results:
            Console.Write("Coords 1: ");
            Console.WriteLine("x = {0}, y = {1}", coords3.x, coords3.y);



            Book? book123=null; //nullable type; if your remove ? get erro for keyword null

            Book b1Obj=new Book("xx", "yy",564);
            Console.WriteLine(b1Obj.DiaplyBookDetails());

            // Keep the console window open in debug mode.
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();

        }
        public static void loopDemos()
        {
            int a = 10;

            /* while loop execution */
            while (a < 20)
            {
                Console.WriteLine("value of a: {0}", a);
                a++;
            }

            /* for loop execution */
            for (int b = 10; b < 20; b++)
            {
                Console.WriteLine("value of b: {0}", b);
            }


            /* local variable definition */
            int c = 10;

            /* do loop execution */
            do
            {
                Console.WriteLine("value of c: {0}", c);
                c += 1;
            }
            while (c < 20);


            int[] Marks = new int[5] { 99, 98, 92, 97, 95 };
            foreach (int mark in Marks)
            {
                Console.WriteLine("Mark={0}", mark);
            }
        }
    }

    
        
    }

enum WeekDays
{
    Monday,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday,
    Sunday
}
public struct Coords
{
    public int x, y;

    public Coords(int p1, int p2)
    {
        x = p1;
        y = p2;
    }
}

public struct Book
{
    //member variables
    public string bookName;
    public string bookAuthor;
    public int bookPrice;

    //parametric constructor
    public Book(string bnm, string aut, int p)
    {
        bookName = bnm;
        bookAuthor = aut;
        bookPrice = p;
    }
    public string DiaplyBookDetails()
    {
        string str = string.Format("Name = {0}\t Author={1}\t Price={2}", bookName, bookAuthor, bookPrice);
        return str;
    }

}