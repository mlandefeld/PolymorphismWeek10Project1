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
        private string status = "Available";

        List<string> resources = new List<string>();


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
            Console.WriteLine("Title: " + title);
            Console.WriteLine("ISBN: " + isbn);
            Console.WriteLine("Length: " + length + " pages.");
            Console.WriteLine("Status: " + status);
        } 

        public virtual void AddTitle()
        {
            Console.Write("Enter then name of the resource you wish to add: ");
            string newTitle = Console.ReadLine();
            resources.Add(newTitle);
            Console.Write("Enter the ISBN: ");
            string newIsbn = Console.ReadLine();
            Console.Write("What is the page length? ");
            int newLenght = int.Parse(Console.ReadLine());
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
