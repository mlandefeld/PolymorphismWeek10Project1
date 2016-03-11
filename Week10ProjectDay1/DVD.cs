using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week10ProjectDay1
{
    class DVD : Resource
    {
        public override void AddTitle()
        {
            Console.WriteLine("What is the title you wish to add? ");
            string title = Console.ReadLine();
            Console.WriteLine("What is the isbn? ");
            int isbn = int.Parse(Console.ReadLine());
            Console.WriteLine("What is the length in minutes? ");
            int length = int.Parse(Console.ReadLine());
            this.Status = "Available";
        }

    }
}
