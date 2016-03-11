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

        public virtual void ViewTitle()
        {
            Console.WriteLine( this.Title + " " + this.ISBN + " " + this.Length + " pages " + this.Status);
        }

        public virtual void AddTitle()
        {
            Console.WriteLine("What is the title you wish to add? ");
            string title = Console.ReadLine();
            Console.WriteLine("What is the isbn? ");
            int isbn = int.Parse(Console.ReadLine());
            Console.WriteLine("What is the page length?");
            int length = int.Parse(Console.ReadLine());
            this.Status = "Available";
        }

        public virtual void CheckOut()
        {
            Console.Write("Enter then name of the resource you wish to check out: ");
            string returnTitle = Console.ReadLine();
            DateTime today = DateTime.Now;
            DateTime answer = today.AddDays(3);
            Console.WriteLine(returnTitle+ " has been checked out.");
            Console.WriteLine(answer + " due date is: ");

        }

        public virtual void CheckIn()
        {
            Console.WriteLine("Enter then name of the resource you wish to return: ");
            string checkInTitle = Console.ReadLine();
            Console.WriteLine("Thank you for your return of " + checkInTitle + ".");
        }

    }
}
