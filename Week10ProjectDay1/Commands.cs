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
            objects.Add(new DVD("The Best Movie", 1212121212, 120));
            objects.Add(new Book("The Most Interesting Book", 1313131313, 450));
            objects.Add(new Magazine("The Coolest Magazine", 1414114141, 150));

            this.resources = objects;
        }

        public void AddResource(int type, string title, int isbn, int length)
        {
            Resource resource;
            if (type == 1)
            {
                DVD dvd = new DVD("test", 45, 7);
                resource = dvd.AddTitle(title, isbn, length);
            }
            else if (type == 2)
            {
                Book book = new Book("test", 45, 7);
                resource = book.AddTitle(title, isbn, length);
            }
            else if (type == 3)
            {
                Magazine magazine = new Magazine("test", 45, 7);
                resource = magazine.AddTitle(title, isbn, length);
            }
            else
            {
                throw new Exception();
            }

            this.resources.Add(resource);
        }

        public void ViewResources()
        {
            foreach(Resource resource in this.resources)
            {                
                Console.WriteLine(resource.ViewTitle());
            }
        }
        public static void Exit()
        {
            Console.Clear();
            Console.WriteLine("\nI hope you found this Resource Library Helpful!\n");
            Environment.Exit(0);
        }
    }
}
