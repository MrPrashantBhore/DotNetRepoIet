using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Reflectiondemos
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("hey watch its a refelction demo");
            //  Demo1();
            //  demo2();

            //for car demo
            Type t = typeof(Car);
            GetCarParametersInfo(t);


            //dynamically loading assembly and perform reflection
            // DemoDynamicAssemblyReflection();
            //Late bidning //dynamic refl
             demoDynamic2();
            Console.WriteLine("\r\nPress ENTER to exit.");
            Console.ReadLine();
        }

        public static void Demo1()
        {
            Console.WriteLine("\nReflection.MemberInfo");
            // Gets the Type and MemberInfo.
            Type MyType = Type.GetType("System.IO.File");
            MemberInfo[] Mymemberinfoarray = MyType.GetMembers();
            // Gets and displays the DeclaringType method.
            Console.WriteLine("\nThere are {0} members in {1}.",
                Mymemberinfoarray.Length, MyType.FullName);
            Console.WriteLine("{0}.", MyType.FullName);
            if (MyType.IsPublic)
            {
                Console.WriteLine("{0} is public.", MyType.FullName);
            }
        }
        public static void demo2()
        {
            // Specifies the class. //
            Type t = typeof(System.IO.BufferedStream);
            Console.WriteLine("Listing all the members (public and non public) of the {0} type", t);

            // Lists static fields first.
            FieldInfo[] fi = t.GetFields(BindingFlags.Static |
                BindingFlags.NonPublic | BindingFlags.Public);
            Console.WriteLine("// Static Fields");
            PrintMembers(fi);

            // Static properties.
            PropertyInfo[] pi = t.GetProperties(BindingFlags.Static |
                BindingFlags.NonPublic | BindingFlags.Public);
            Console.WriteLine("// Static Properties");
            PrintMembers(pi);

            // Static events.
            EventInfo[] ei = t.GetEvents(BindingFlags.Static |
                BindingFlags.NonPublic | BindingFlags.Public);
            Console.WriteLine("// Static Events");
            PrintMembers(ei);

            // Static methods.
            MethodInfo[] mi = t.GetMethods(BindingFlags.Static |
                BindingFlags.NonPublic | BindingFlags.Public);
            Console.WriteLine("// Static Methods");
            PrintMembers(mi);

            // Constructors.
            ConstructorInfo[] ci = t.GetConstructors(BindingFlags.Instance |
                BindingFlags.NonPublic | BindingFlags.Public);
            Console.WriteLine("// Constructors");
            PrintMembers(ci);

            // Instance fields.
            fi = t.GetFields(BindingFlags.Instance | BindingFlags.NonPublic |
                BindingFlags.Public);
            Console.WriteLine("// Instance Fields");
            PrintMembers(fi);

            // Instance properites.
            pi = t.GetProperties(BindingFlags.Instance | BindingFlags.NonPublic |
                BindingFlags.Public);
            Console.WriteLine("// Instance Properties");
            PrintMembers(pi);

            // Instance events.
            ei = t.GetEvents(BindingFlags.Instance | BindingFlags.NonPublic |
                BindingFlags.Public);
            Console.WriteLine("// Instance Events");
            PrintMembers(ei);

            // Instance methods.
            mi = t.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic
                | BindingFlags.Public);
            Console.WriteLine("// Instance Methods");
            PrintMembers(mi);

            Console.WriteLine("\r\nPress ENTER to exit.");
            Console.Read();
        }


        public static void PrintMembers(MemberInfo[] ms)
        {
            StringBuilder OutputText = new StringBuilder();
            foreach (MemberInfo m in ms)
            {
                Console.WriteLine("{0}{1}", "     ", m);
            }

        }


        //car example

        public static void GetCarFields(Type t)
        {
            Console.WriteLine("***** Fields *****");
            FieldInfo[] fi = t.GetFields();
            foreach (FieldInfo field in fi)
                Console.WriteLine("->{0}", field.Name);
            Console.WriteLine("");
        }
        // Display property names of type.  
        public static void GetCarProperties(Type t)
        {
            Console.WriteLine("***** Properties *****");
            PropertyInfo[] pi = t.GetProperties();
            foreach (PropertyInfo prop in pi)
                Console.WriteLine("->{0}", prop.Name);
            Console.WriteLine("");
        }

        public static void GetCarInterfaces(Type t)
        {
            Console.WriteLine("***** Interfaces *****");
            Type[] ifaces = t.GetInterfaces();
            foreach (Type i in ifaces)
                Console.WriteLine("->{0}", i.Name);
        }


        public static void GetCarParametersInfo(Type t)
        {
            Console.WriteLine("***** GetParametersInfo *****");
            MethodInfo[] mi = t.GetMethods();
            foreach (MethodInfo m in mi)
            {
                // Get return value.  
                string retVal = m.ReturnType.FullName;
                Console.WriteLine("Method Name {0}" , m.Name);
                StringBuilder paramInfo = new StringBuilder();
                paramInfo.Append("(");

                // Get params.  
                foreach (ParameterInfo pi in m.GetParameters())
                {
                    paramInfo.Append(string.Format("{0} {1} ", pi.ParameterType, pi.Name));
                }
                paramInfo.Append(")");

                // Now display the basic method sig.  
                Console.WriteLine("->Return type - {0} Method Name -{1} parameter Info-{2}", retVal, m.Name, paramInfo);
            }
            Console.WriteLine("");
        }
    

//Dynamically loading an Asembly and performing relection
    public static void DemoDynamicAssemblyReflection()
        {
               string TypeName = "";
            Assembly asm = Assembly.LoadFile(@"D:\MathLibrary.dll");
            //Discover what types MathLibrary.dll.dll contains
            Type[] mathtype = asm.GetTypes();
            foreach (Type t in mathtype)
            {
                Console.WriteLine("\n" + t.FullName + " is Found\n\n");
                TypeName = t.FullName;
            }

            //Discovering all the members of type in StudentType  
            Console.WriteLine("Members contained by " + TypeName + " are as follows::\n");
            foreach (Type t in mathtype)
            {
                //Console.WriteLine(t.Name);
                MemberInfo[] mathMembers;
                mathMembers = t.GetMembers();//get all the members
                foreach (MemberInfo m in mathMembers)//iterating through members 
                {
                    Console.WriteLine(m.Name);
                }
                MethodInfo[] mathMethods;
                mathMethods = t.GetMethods();//get all the methods
                foreach (MethodInfo m1 in mathMethods)//iterating through methods 
                {
                    Console.WriteLine(m1.Name);
                }
            }

            Console.ReadLine();
        }

        //Late binding Dynamic Binding
        public static void demoDynamic2()
        {

            MethodInfo method;
            //object result = new object();
            object[] args = new object[] { 4 };
            object[] args1 = new object[] { 4, 16 };
            Assembly testAssembly = Assembly.LoadFrom(@"D:\MathLibrary.dll");
            Type calcType = testAssembly.GetType("MathLibrary.MathCalculator");
            object calcInstance1 = Activator.CreateInstance(calcType, args1);
            MethodInfo mi1 = calcType.GetMethod("DoAdd");
            object res1 = null;
            res1 = mi1.Invoke(calcInstance1, null);
            Console.WriteLine("Addd is: {0}", res1.ToString());

            object calcInstance = Activator.CreateInstance(calcType, args1);
            MethodInfo mi = calcType.GetMethod("SquareIT");
            object res = null;
            res = mi.Invoke(calcInstance, args);
            Console.WriteLine("Square is: {0}", res.ToString());

            Object calcInstanc2 = Activator.CreateInstance(calcType, args1);
            MethodInfo mi3 = calcType.GetMethod("Dispaly");
            object res3 = null;
            res3 = mi3.Invoke(calcInstanc2, null);
            Console.WriteLine("Message is: {0}", res3.ToString());

        }


       

    }
}
