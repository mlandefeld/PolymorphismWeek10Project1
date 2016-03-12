using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week10ProjectDay1
{
    class Commands
    {
        public List<Resource> resources; 

        public Commands()
        {
            List<Resource> objects = new List<Resource>();
            objects.Add(new DVD("DVD Title", 100, 1));
            objects.Add(new Book("Book Title",200, 2));
            objects.Add(new Magazine("Magazine Title", 300, 3));

            this.resources = objects;
        }

        public List<Resource> Resources
        {
            get { return this.resources; }
        }

        public static void Exit()
        {
            Console.Clear();
            Console.WriteLine("\nI hope you found this Resource Library Helpful!\n");
            Environment.Exit(0);
        }
    }
}
