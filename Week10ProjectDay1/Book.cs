using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week10ProjectDay1
{
    class Book : Resource
    {
        private string title = "The Most Interesting Book";
        private int isbn = 1111111111;
        private int length = 583;
        private string status = "Available";

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

        public override void ViewTitle()
        {
            Console.WriteLine("Title: " + title);
            Console.WriteLine("ISBN: " + isbn);
            Console.WriteLine("Length: " + length + " pages.");
            Console.WriteLine("Status: " + status);
            base.AddTitle();
        }
    }
}
