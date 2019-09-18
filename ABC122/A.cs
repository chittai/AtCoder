using System;

namespace ABC122
{
    class A
    {
        static void Main(string[] args)
        {
            string b = Console.ReadLine();

            if (b == "A") { Console.WriteLine("T"); }
            if (b == "T") { Console.WriteLine("A"); }
            if (b == "G") { Console.WriteLine("C"); }
            if (b == "C") { Console.WriteLine("G"); }
        }
    }
}
