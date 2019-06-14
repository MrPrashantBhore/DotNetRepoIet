using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LINQ_SQL_Demos.Model;
namespace LINQ_SQL_Demos
{
    class Program
    {
        public static MyDBDataContext ObjCtx = null;


        static void Main(string[] args)
        {
            Console.WriteLine("Started");
            //ListAllItems();
            // AddItem();
            //ModifyItem(1008);
            ListAllItems();
            DeleteItem(1009);
            ListAllItems();
            Console.WriteLine("Done");
            Console.ReadLine();
        }
        static void AddItem()
        {
           ObjCtx = new MyDBDataContext();
            //Console.WriteLine("enter Item code");
            //int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter Item Name");
            string name = Console.ReadLine();
            Console.WriteLine("enter price");
            int pce = Convert.ToInt32(Console.ReadLine());
            Item itemObj = new Item();
            //itemObj.ItemCode = id;
            itemObj.ItemName = name;
            itemObj.Price = pce;
            ObjCtx.Items.InsertOnSubmit(itemObj);
            try
            {
                ObjCtx.SubmitChanges();
                Console.WriteLine("inserted...");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void ModifyItem(int itemId)
        {
            ObjCtx = new MyDBDataContext();
            Console.WriteLine("Enter new title");
            string name = Console.ReadLine();
            Console.WriteLine("Enter the modified price");
            int pce = Console.Read();

            var mResult = from item in ObjCtx.Items
                          where item.ItemCode == itemId
                          select item;

            foreach (var bk in mResult)
            {
                //bk.bookId = bk.bk
                bk.ItemName = name;
                bk.Price = pce;
            }
            try
            {
                ObjCtx.SubmitChanges();
                Console.WriteLine("updated...");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        static void DeleteItem(int itemid)
        {
            ObjCtx = new MyDBDataContext();
            var mResult = from item in ObjCtx.Items
                         where item.ItemCode == itemid
                          select item;

            foreach (var bk in mResult)
                ObjCtx.Items.DeleteOnSubmit(bk);
            try
            {
                ObjCtx.SubmitChanges();
                Console.WriteLine("deleted...");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        void FilterItemsById(int itemid)
        {
            ObjCtx = new MyDBDataContext();
            var mResult = from item in ObjCtx.Items
                          where item.ItemCode == itemid
                          select item;

            foreach (var item in mResult)
            {
                Console.WriteLine(item.ItemCode + " " + item.ItemName + " " + item.Price);
            }
        }
        static void ListAllItems()
        {
            ObjCtx = new MyDBDataContext();
            var mResult = from allitem in ObjCtx.Items
                              // where books.price 
                          select allitem;
            // displays all available books
            foreach (var item in mResult)
            {
                Console.WriteLine(item.ItemCode + " " + item.ItemName + " " + item.Price);
            }
        }
    }
}
