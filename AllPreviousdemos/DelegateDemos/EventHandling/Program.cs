using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventHandling
{
    public delegate string MyDel(string str);
    //anonymous del
    public delegate void Test();

    class EventProgram
    {
        event MyDel MyEvent;

        public EventProgram()
        {
            this.MyEvent += new MyDel(this.WelcomeUser);
        }
        public string WelcomeUser(string username)
        {
            return "Welcome " + username;
        }
        static void Main(string[] args)
        {
            #region
            //EventProgram obj1 = new EventProgram();
            //string result = obj1.MyEvent("TechnolSolutions Ltd");
            //Console.WriteLine(result);
            //------------------------------------------
            #endregion

            //2 
            int Marks;
            Console.WriteLine("Enter the marks of student");
            Marks = Convert.ToInt32(Console.ReadLine());
            StudentMarks s1 = new StudentMarks();
            s1.Pass += new MarksDel(PassMethod);//Registering event handler with appropriate method which is going to be invoked when event will raise
            s1.Fail += new MarksDel(FailMethod);//Registering event handler with appropriate method which is going to be invoked when event will raise
            s1.ShowResult(Marks);//Invoke appropriate method depending upon the user input

            //annymous del
            //Test Display = delegate ()
            //{
            //    Console.WriteLine("Anonymous Delegate method");
            //};

            //Display();
            Console.ReadLine();
        }

        //----------------------
        public static void PassMethod()
        {
            Console.WriteLine("Student has passed in exam....");
        }
        public static void FailMethod()
        {
            Console.WriteLine("Student has failed in exam....");
        }
    }
}
