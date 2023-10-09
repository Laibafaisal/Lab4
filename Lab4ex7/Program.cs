using System;

namespace Lab4ex7
{
    class Program
    {
        static void Main(string[] args)
        {
            ParseToNumbersNDates();
        }

        private static void ParseToNumbersNDates()
        {
            int age = int.Parse("27");
            DateTime birthday = DateTime.Parse("4 July 1980");
            Console.WriteLine($"I was born {age} years ago.");
            Console.WriteLine($"My birthday is: {birthday}.");
            Console.WriteLine($"My birthday is: {birthday:D}.");

        }
    }
}
