using System;
using static System.Console;
using static System.Convert;

namespace DoesInternetLie
{
    class Program
    {
        private static void CheckType(object a)
        {
            WriteLine($"{a.GetType()}");
        }

        static void Main(string[] args)
        {
            string b = "5";
            CheckType(b);
            WriteLine("Yes it does, sometimes");
            ReadKey();
        }
    }
}
