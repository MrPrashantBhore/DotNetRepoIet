#define PERLS
#define PYTHONS
#define NET
#undef NET
#define SHAPE
#undef SHAPE 
//Uncomment to see compilation & errormessage
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreProcessorDDemos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Started");
            //Demo();
            ListAllItems();
            Console.WriteLine("Done");
            Console.ReadLine();
        }

        public static void preprocDemo()
        {
#if PERLS
            Console.WriteLine("PERLS"); // Compiled.
#endif

//#if DOT || NET
//       Console.WriteLine("DOT OR NET"); // Skipped.
//#elif PYTHONS
//            Console.WriteLine("PYTHONS"); // Compiled.
//#endif

//#if (PERLS || PYTHONS) && !NET
//            Console.WriteLine("PERLS OR PYTHONS"); // Compiled.
//#endif

//            // Checking if shape exists 
//#if (SHAPE)
//                Console.WriteLine("Shape Exists"); 
                  
//            // Or if shape_ exists 
//#elif (SHAPE)
//                Console.WriteLine("Shape_ Exists" ); 
                  
//#else

            // using #warning to display message that 
            // none of the symbols were found 
#warning "No Symbols found" 

            // Generating user defined error 
//#error "Check use of preprocessors-error" 

//            // Ending if 
//#endif
        }
        public static void AddItem()
        {
            DataClasses1DataContext ctx = new DataClasses1DataContext();
            Item obj = new Item();
            //obj.ItemCode = 123;
            obj.ItemName = "Denim Jeans";
            obj.Price = 1500;
            ctx.Items.InsertOnSubmit(obj);
            ctx.SubmitChanges();


        }

        static void ListAllItems()
        {
            DataClasses1DataContext ctx = new DataClasses1DataContext();
            var mResult = from prod in ctx.Items
                              // where books.price 
                          select new { prod.ItemCode,prod.ItemName,prod.Price };
            // displays all available books
            foreach (var item in mResult)
            {
                Console.WriteLine(item.ItemCode + " " + item.ItemName + " " + item.Price);
            }
        }
    }
}
