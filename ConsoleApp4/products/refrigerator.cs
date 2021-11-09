using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4.products
{
    class refrigerator : product
    {
        public override string Brend()
        {
            return "Samsung";
        }

        public override int Price()
        {
            return 1299;
        }

        public override bool Warranty()
        {
            return true;
        }

        public override int Year()
        {
            return 2021;
        }
    }
}
