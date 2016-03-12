using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week10ProjectDay1
{
    class Program
    {
        static void Main(string[] args)
        {
            Commands command = new Commands();

            foreach(Resource resource in command.Resources)
            {
                Console.WriteLine("************************");
                resource.ViewTitle();
            }

            foreach (Resource resource in command.Resources)
            {
                Console.WriteLine("************************");
                resource.AddTitle();
                resource.ViewTitle();
            }

            foreach (Resource resource in command.Resources)
            {
                Console.WriteLine("************************");
                resource.CheckOut();
                resource.ViewTitle();
            }

            foreach (Resource resource in command.Resources)
            {
                Console.WriteLine("************************");
                resource.CheckIn();
                resource.ViewTitle();
            }

            

        }
    }
}
