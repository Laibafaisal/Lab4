using System;

namespace Lab4_213002
{
    class Program
    {
        static void Main(string[] args)
        {
            CastIntNDoubles();
        }

        private static void CastIntNDoubles()
        {
            int a = 10;
            double b = a;
            Console.WriteLine($"B is {b}");

            double c = 9.8;
            int d = (int)c;
            Console.WriteLine($"D is {d}");

            long e = 10;
            int f = (int)e;
            Console.WriteLine($"E is {e} and F is {f}.");

        }
    }
}
