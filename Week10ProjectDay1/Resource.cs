using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week10ProjectDay1
{
    abstract class Resource
    {
        private string title;
        private int isbn;
        private int length;
        private string status;

        public string Title
        {
            get { return this.title; }
            set { this.title = value; }
        }

        public int ISBN
        {
            get { return this.isbn; }
            set { this.isbn = value; }
        }

        public int Length
        {
            get { return this.length; }
            set { this.length = value; }
        }

        public string Status
        {
            get { return this.status; }
            set { this.status = value; }
        }

        public Resource(string title, int isbn, int length)
        {
            this.Title = title;
            this.ISBN = isbn;
            this.ISBN = length;
            this.Status = "Available";
        }


        public virtual void ViewTitle()
        {
            Console.WriteLine( this.Title + ", " + this.ISBN + ", " + this.Length + " pages, " + this.Status);
        }

        public virtual void AddTitle()
        {
            Console.WriteLine("What is the title you wish to add? ");
            string title = Console.ReadLine();
            Console.WriteLine("What is the isbn? ");
            int isbn = int.Parse(Console.ReadLine());
            Console.WriteLine("What is the page length?");
            int length = int.Parse(Console.ReadLine());

            this.Title = title;
            this.ISBN = isbn;
            this.Length = length;

            this.Status = "Available";
        }

        public virtual void CheckOut()
        {
            this.Status = "Checked Out";
            DateTime today = DateTime.Now;
            DateTime answer = today.AddDays(3);

            Console.WriteLine("The item is due back in three days.");
            Console.WriteLine(this.Title + " has been checked out.");
            Console.WriteLine("Due date is: "+answer);
        }

        public virtual void CheckIn()
        {
            this.Status = "Available";
        }

    }
}
