using System;

namespace Lab4ex6
{
    class Program
    {
        static void Main(string[] args)
        {
            ConvertToString();
        }

        private static void ConvertToString()
        {
            int number = 12;
            Console.WriteLine(number.ToString());

            bool boolean = true;
            Console.WriteLine(boolean.ToString());

            DateTime Now = DateTime.Now;
            Console.WriteLine(Now.ToString());

            object me = new object();
            Console.WriteLine(me.ToString());
        }
    }
}
