using System;

namespace RationalNumbers
{
    class Program
    {
        static void Main()
        {
            IRationalNumber r = new RationalNumber(3, 5);
            Console.WriteLine($"This is the rational number: {r}");
        }
    }
}
