using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//used in   public static List<Book> DemoGenList() firstDemo.cs

namespace CoolelctionDemos
{
    public class Book
    {
        public string BookName { get; set; }
        public string Author { get; set; }
        public int Price { get; set; }

        public Book()
        {
            this.BookName = "Let US Learn";
            this.Author = "xyz";
            this.Price = 345;
        }

        public override string ToString()
        {
            return  this.BookName + "\t" + this.Author + "\t" + this.Price;
        }
    }
}
