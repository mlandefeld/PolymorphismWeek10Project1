using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week10ProjectDay1
{
    class Book : Resource
    {
        public Book(string title, int isbn, int length) : base(title, isbn,length)
        {

        }

        public override void CheckOut()
        {
            this.Status = "Checked Out";
            DateTime today = DateTime.Now;
            DateTime answer = today.AddDays(5);

            Console.WriteLine("The item is due back in five days.");
            Console.WriteLine(this.Title + " has been checked out.");
            Console.WriteLine("Due date is: " + answer);
        }
    }
}
