using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week10ProjectDay1
{
    class DVD : Resource
    {
        private string title = "The Best Movie";
        private int isbn;
        private int length;
        private string status = "Available";

        public override void ViewTitle()
        {
            base.ViewTitle();
            Console.WriteLine("Title: " + title);
            Console.WriteLine("ISBN: " + isbn);
            Console.WriteLine("Length: " + length + " minutes.");
            Console.WriteLine("Status: " + status);
            
        }

        public override void AddTitle()
        {
            Console.Write("What is the length of the DVD (in minutes): ");
            int newDvdLenght = int.Parse(Console.ReadLine());
            base.AddTitle();
        }
    }
}
