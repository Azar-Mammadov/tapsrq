using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4.products
{
    public abstract class product
    {
        public abstract  string Brend();

        public abstract  int Price();

        public abstract int Year();

        public abstract bool Warranty();
    }
}
