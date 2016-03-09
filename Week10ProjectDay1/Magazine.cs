using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week10ProjectDay1
{
    class Magazine : Resource
    {
        private string title = "The Coolest Magazine";
        private int isbn;
        private int length;
        private string status = "Available";

        public override void CheckOut()
        {
            Console.Write("Enter then name of the resource you wish to check out: ");
            string returnTitle = Console.ReadLine();
            DateTime today = DateTime.Now;
            DateTime answer = today.AddDays(2);
            Console.WriteLine(returnTitle + " has been checked out.");
            Console.WriteLine(answer + " due date is: ");
            base.CheckOut();
        }
    }
}
