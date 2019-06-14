using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace CoolelctionDemos
{
    public class FirstDemo
    {
        public static ArrayList sports = new ArrayList() { "Badminton", "Cricket", "Football", "Swimming" };
        public static void DemoArrayList()
        {
            ArrayList myArryList = new ArrayList();
            myArryList.Add(1);
            myArryList.Add("Two");
            myArryList.Add(3);
            myArryList.Add(4.5f);
            foreach (var val in myArryList)
                Console.WriteLine(val);

        }
        public static ArrayList GetAllSports()
        {
            //ArrayList products = new ArrayList() { "Badminton", "Cricket", "Football", "Swimming" };
            return sports;
        }


        public static ArrayList ListAllSports
        {

            get
            {
                return sports;
            }

        }

        public static void DemoStack()
        {//LIFO
            //allows null and duplicate values
            Stack myStack = new Stack();
            myStack.Push("Hello!!");
            myStack.Push(null);
            myStack.Push(1);
            myStack.Push(2);
            myStack.Push(3);
            myStack.Push(4);
            myStack.Push(5);
            myStack.Push(1);

            foreach (var itm in myStack)
                Console.Write(itm);

            Console.WriteLine(myStack.Peek());

            Console.Write("Number of elements in Stack: {0}", myStack.Count);

            Console.WriteLine(myStack.Pop());

            Console.Write("Number of elements in Stack: {0}", myStack.Count);

            myStack.Contains(2); // returns true

            myStack.Clear(); // removes all elements

            Console.Write("Number of elements in Stack: {0}", myStack.Count);




        }


        public static void DemoQueue()
        {//FIFO
         //It contains the elements in the order they were added.
         //Queue collection allows multiple null and duplicate values.
         //Use the Enqueue() method to add values and 
         //the Dequeue() method to retrieve the values from the Queue.

            Queue queue = new Queue();
            queue.Enqueue(3);
            queue.Enqueue(2);
            queue.Enqueue(1);
            queue.Enqueue("Four");

            Console.WriteLine("Number of elements in Queue: {0}", queue.Count);

            foreach (var i in queue.ToArray())
                Console.WriteLine(i);
            Console.WriteLine("Number of elements in the Queue: {0}", queue.Count);

            Console.WriteLine(queue.Peek());
            Console.WriteLine("Number of elements in Queue: {0}", queue.Count);

            queue.Contains(2);


        }

        public static Hashtable GetFruits
        {
            get
            {
                Hashtable ht = new Hashtable()
                {
                    { 1, "Apple" },
                    { 2, "Banana" },
                    { 3, "Cherry" },
                    { 4, "Mangoes" },
                    { 5, "15" }

                };
                return ht;
            }

        }



        public static List<Book> DemoGenList()
        {

            List<string> names = new List<string>() {
                "Emma","Jack","Jonathan","sara"
            };
            List<Book> bookList = new List<Book>()
            {
                new Book(){ BookName="Leran Cooking",Author="Sanjjev kapoor",Price= 900},
                new Book(){ BookName="Palnets in details",Author="ABC",Price= 2000},
                new Book(){ BookName="System Programming",Author="Tanenbaum",Price= 700}
            };

            return bookList;
        }
        //custom Ienumrator //uses team class
        public static void CustomUseOfEnumerator()
        {
            Team team = new Team();
            Console.WriteLine("-------PLayers List--------");
            while (team.MoveNext())
            {

                Players player = (Players)team.Current;
                //Console.WriteLine(team.Current);
                Console.WriteLine("Name={0},Age={1},Runs={2}", player.Name, player.Age, player.Runs);

            }

        }

        //uses football class
        public static void CustomUseOfEnumerable()
        {
            FootBallTeam Fteam = new FootBallTeam();
            Console.WriteLine("-------Football PLayers --------");
            foreach (FootballPlayers player in Fteam)
            {
                Console.WriteLine("Name={0},Age={1},Goals={2}", player.Name, player.Age, player.Goals);
            }
        }

        //additonal
        public static void UseofComparable()
        {

            CricketPlayers SachinObj = new CricketPlayers { Name = "Sachin", Age = 30, Runs = 2000 };

            CricketPlayers DhoniObj = new CricketPlayers { Name = "Dhoni", Age = 29, Runs = 1200 };

            //Compare Sachinobj with DhoniObj

            int state = SachinObj.CompareTo(DhoniObj);

            if (state == 1) Console.WriteLine("Sachins runs - {0} has scored runs more than Dhonis Runs -{1} ", SachinObj.Runs, DhoniObj.Runs);

            if (state == -1) Console.WriteLine("Sachins runs - {0} has scored runs less than Dhonis Runs- {1} ", SachinObj.Runs, DhoniObj.Runs);

            if (state == 0) Console.WriteLine("Sachins runs - {0} and  Dhonis Runs-{1} are equal", SachinObj.Runs, DhoniObj.Runs);
        }


        
        //uses demo.cs //IComparer compares two objects -non generic
        public static void DemoEmployee()
        {
            //Employee[] elist = new Employee[2];
            //elist[0] = new Employee { Name = "Sara",Salary= 75000 };
            //elist[1] = new Employee { Name = "Emma", Salary = 65000 };



            CompareEmpByName obj = new CompareEmpByName();
            Employee ex = new Employee { Name = "Sara", Salary = 75000 };
            Employee ey = new Employee { Name = "Anna", Salary = 1000 };
            CompareEmpByName nameobj = new CompareEmpByName();
            int len = nameobj.Compare(ex, ey);
            if (len == -1) Console.WriteLine("The first string precedes the second string in the sort order");

            if (len == 1) Console.WriteLine("The first string follows the second string in the sort order.");

            if (len == 0) Console.WriteLine("Both strings are equal in value.");

            CompareEmpBySalary esal = new CompareEmpBySalary();
            int anum = esal.Compare(ex, ey);
            if (anum == 1) Console.WriteLine("{0} salary is {1} greater than {2} salary{3}  ", ex.Name, ex.Salary, ey.Name, ey.Salary);

            if (anum == -1) Console.WriteLine("{0} salary is {1} less than {2} salary{3}  ", ex.Name, ex.Salary, ey.Name, ey.Salary);

            if (anum == 0) Console.WriteLine("{0} and {1} have slary {2} -{3} ", ex.Name, ey.Name, ex.Salary, ey.Salary);
            
        }

        //use of Icopmararer<t>
        public static void usingDemoII()
        {
            //uses DemoII.cs
           // Use Collection Initializers(C# 3.0 ) to initialize the List 
        List<EmployeeOne> empList = new List<EmployeeOne>()
        { new EmployeeOne { Name = "xx", Salary = 14000 },
          new EmployeeOne { Name = "bb", Salary = 500 }
         };
            
            EmployeeOne aa1=new EmployeeOne() { Name = "xx", Salary = 14000 };
            EmployeeOne aa2 = new EmployeeOne() { Name = "bb", Salary = 500 };


            int anum = aa1.CompareTo(aa2);
            if (anum == 1) Console.WriteLine("{0} salary is {1} greater than {2} salary{3}  ", aa1.Name, aa1.Salary, aa2.Name, aa2.Salary);

            if (anum == -1) Console.WriteLine("{0} salary is {1} less than {2} salary{3}  ", aa1.Name, aa1.Salary, aa2.Name, aa2.Salary);

            if (anum == 0) Console.WriteLine("{0} and {1} have slary {2} -{3} ", aa1.Name, aa1.Name, aa2.Salary, aa2.Salary);

            Employee_SortBySalaryByAscendingOrder eAsc =
                    new Employee_SortBySalaryByAscendingOrder();
            // Sort Employees by salary by ascending order. 
            Console.WriteLine("Sort Employees by salary by ascending order.  ");
            empList.Sort(eAsc);
           
            foreach (var item in empList)
            {
                Console.WriteLine(item.Name + " " + item.Salary);
            }
            Console.WriteLine("Sort Employees by salary by descending order.  ");
            Employee_SortBySalaryByDescendingOrder eDsc =
                    new Employee_SortBySalaryByDescendingOrder();
            // Sort Employees by salary by descending order. 
            empList.Sort(eDsc);
            foreach (var item in empList)
            {
                Console.WriteLine(item.Name + " " + item.Salary);
            }
            Employee_SortByName eName = new Employee_SortByName();
            // Sort Employees by their names.   
            Console.WriteLine("Sort Employees by their names. ");
            empList.Sort(eName);
            foreach (var item in empList)
            {
                Console.WriteLine(item.Name + " " + item.Salary);
            }
        }


        //use of custom interface & class  -Demo_Int_Class_Generics.cs file
        public static void DemoSwapping()
        {
            int x = 4;
            int y = 7;
            mygenSwap<int> objInt = new mygenSwap<int>();
            objInt.Swap(ref x, ref y);

        }
    }
}
