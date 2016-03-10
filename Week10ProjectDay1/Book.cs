using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week10ProjectDay1
{
    class Book : Resource
    {
        public Book(string title, int isbn, int length) : base(title, isbn, length)
        {

        }

        public override void CheckOut()
        {
            Console.WriteLine("Enter then name of the resource you wish to check out: ");
            string returnTitle = Console.ReadLine();
            DateTime today = DateTime.Now;
            DateTime answer = today.AddDays(5);
            Console.WriteLine(returnTitle + " has been checked out.");
            Console.WriteLine(answer + " due date is: ");
            base.CheckOut();
        }

        public override Resource AddTitle(string title, int isbn, int length)
        {
            Book book = new Book(title, isbn, length);
            return book;
        }
    }
}
