using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week10ProjectDay1
{
    class DVD : Resource
    {

        public DVD(string title, int isbn, int length) : base(title, isbn,length)
        {

        }

        public override void ViewTitle()
        {
            Console.WriteLine(this.Title + ", " + this.ISBN + ", " + this.Length + " minutes, " + this.Status);
        }

        public override void AddTitle()
        {
            Console.WriteLine("What is the DVD title you wish to add? ");
            string title = Console.ReadLine();
            Console.WriteLine("What is the isbn? ");
            int isbn = int.Parse(Console.ReadLine());
            Console.WriteLine("What is the length in minutes? ");
            int length = int.Parse(Console.ReadLine());
            this.Status = "Available";
            this.Title = title;
            this.ISBN = isbn;
            this.Length = length;
        }

    }
}
