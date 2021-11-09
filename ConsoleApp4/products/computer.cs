using System;


namespace ConsoleApp4.products
{
    public class computer : product
    {
        public override string Brend()
        {
            return "Asus";
        }

        public override int Price()
        {
            return 2699;
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
