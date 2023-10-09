using System;

namespace ValueTypeTest
{
    class DemoRefDataTypes
    {
        static void Main(string[] args)
        {
            string a = "Salam";
            a += "for";
            a = a + "all";
            Console.WriteLine(a);

            object obj;
            obj = 20;
            Console.WriteLine(obj);

            Console.WriteLine(obj.GetType());
        }
    }
}

