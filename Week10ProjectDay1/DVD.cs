using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week10ProjectDay1
{
    class DVD : Resource
    {
        public DVD(string title, int isbn, int length) : base(title, isbn, length)
        {

        }

        public override string ViewTitle()
        {
            return this.Title + " " + this.ISBN + " " + this.Length + " minutes " + this.Status;
        }

        public override Resource AddTitle(string title, int isbn, int length)
        {
            DVD dvd = new DVD(title, isbn, length);

            return dvd;
        }

    }
}
